/* Copyright 2018- underdolphin

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using Angelina.Lib.Values.BMS;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Angelina.Lib.FileIO.Reader
{
    public class BmsReader
    {
        private (string commandKind,string commandValue,int measureCount,int chNo) GetCommand(string commandString)
        {
            var retNullValue = ("", "", 0, 0);

            // すべてのコマンドは#で始まるのでそうでない場合は処理をショートカット
            if (!commandString.StartsWith("#"))
            {
                return retNullValue;
            }

            // チャンネルの構文と一致する
            if (Regex.IsMatch(commandString, @"#\d{5}:[0-9A-Za-z]*"))
            {
                var commandKind = "Channel";
                var separateCommandString = Regex.Split(commandString, ":");
                var measureCount = int.Parse(separateCommandString[0].Substring(1, 3));
                var chNo = int.Parse(separateCommandString[0].Substring(4,2));
                return (commandKind, separateCommandString[1], measureCount, chNo);
            }

            // ヘッダーの構文と一致する
            if (Regex.IsMatch(commandString, @"#[a-zA-Z][a-zA-Z0-9]*\s+[\w.\s\/]*"))
            {
                var separateCommandString = Regex.Split(commandString, @"\s+");
                var commandKind = separateCommandString[0].Substring(1);
                string commandValue = "";
                for (int i = 1; i < separateCommandString.Length; i++)
                {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                    commandValue = commandValue + separateCommandString[i];
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
                }
                return (commandKind.ToUpper(), commandValue, 0, 0);
            }

            return retNullValue;
        }

        public BmsMetaInfoValues MetaInfoRead(string bmsFilePath)
        {
            var metaInfos = new BmsMetaInfoValues();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var reader = new StreamReader(bmsFilePath,Encoding.GetEncoding("Shift_JIS")))
            {
                string readLine = "";
                while ((readLine = reader.ReadLine()) != null)
                {
                    var command = GetCommand(readLine);
                    switch (command.commandKind)
                    {
                        case "PLAYER":
                            metaInfos.Player = int.Parse(command.commandValue);
                            break;
                        case "RANK":
                            metaInfos.Rank = int.Parse(command.commandValue);
                            break;
                        case "TOTAL":
                            metaInfos.Total = int.Parse(command.commandValue);
                            break;
                        case "VOLWAV":
                            metaInfos.VolWav = int.Parse(command.commandValue);
                            break;
                        case "STAGEFILE":
                            metaInfos.StageFile = command.commandValue;
                            break;
                        case "PLAYLEVEL":
                            metaInfos.PlayLevel = int.Parse(command.commandValue);
                            break;
                        case "DIFFICULTY":
                            metaInfos.Difficulty = int.Parse(command.commandValue);
                            break;
                        case "TITLE":
                            metaInfos.Title = command.commandValue;
                            break;
                        case "ARTIST":
                            metaInfos.Artist = command.commandValue;
                            break;
                        case "GENRE":
                            metaInfos.Genre = command.commandValue;
                            break;
                        case "BPM":
                            metaInfos.Bpm = float.Parse(command.commandValue);
                            break;
                        case "MIDIFILE":
                            metaInfos.MidiFile = command.commandValue;
                            break;
                        default:
                            break;
                    }
                }
            }

            return metaInfos;
        }
    }
}
