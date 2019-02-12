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
using Angelina.Lib.FileIO.Reader;
using System;
using static DxLibDLL.DX;

namespace Angelina
{
    public class Program
    {
        public static void Entry()
        {
            ChangeWindowMode(TRUE);
            if (DxLib_Init() == -1)
            {
                return;
            }
            while (ProcessMessage() == 0)
            {
                if (CheckHitKey(KEY_INPUT_ESCAPE) == 1)
                {
                    break;
                }
            }
            DxLib_End();
        }
    }
}
