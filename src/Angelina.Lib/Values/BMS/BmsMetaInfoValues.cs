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
namespace Angelina.Lib.Values.BMS
{
    public class BmsMetaInfoValues
    {
        // Header infos
        public int Player { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public float Bpm { get; set; }
        public string MidiFile { get; set; }
        public int PlayLevel { get; set; }
        public int Rank { get; set; }
        public int VolWav { get; set; }
        public float Total { get; set; }
        public string StageFile { get; set; }
        public int Difficulty { get; set; }

        // Other meta infos
        public int PlayKeys { get; set; }
    }
}
