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
using System.Collections.Generic;

namespace Angelina.Lib.Values.BMS
{
    // TODO: BMLは未実装 2018/11/24
    public class BmsChannelValues
    {
        /// <summary>
        /// #xxx01
        /// </summary>
        public string Ch01BgmChange { get; set; }
        /// <summary>
        /// #xxx02
        /// 小節長
        /// </summary>
        public float Ch02MeasureLengthChange { get; set; }
        /// <summary>
        /// #xxx03
        /// </summary>
        public int CH03BpmChange { get; set; }
        /// <summary>
        /// #xxx04
        /// </summary>
        public string CH04BgaBaseChange { get; set; }
        /// <summary>
        /// #xxx05
        /// </summary>
        public string CH05ExtChrChange { get; set; }
        /// <summary>
        /// #xxx06
        /// </summary>
        public string CH06BgaPoorChange { get; set; }
        /// <summary>
        /// #xxx07
        /// </summary>
        public string CH07BgaLayerChange { get; set; }
        /// <summary>
        /// #xxx08
        /// </summary>
        public int CH08ExtBpmChange { get; set; }
        /// <summary>
        /// #xxx11 1p visible
        /// </summary>
        public List<string> CH11Side1PKey1 { get; set; }
        /// <summary>
        /// #xxx12 1p visible
        /// </summary>
        public List<string> CH12Side1PKey2 { get; set; }
        /// <summary>
        /// #xxx13 1p visible
        /// </summary>
        public List<string> CH13Side1PKey3 { get; set; }
        /// <summary>
        /// #xxx14 1p visible
        /// </summary>
        public List<string> CH14Side1PKey4 { get; set; }
        /// <summary>
        /// #xxx15 1p visible
        /// </summary>
        public List<string> CH15Side1PKey5 { get; set; }
        /// <summary>
        /// #xxx16 1p visible
        /// </summary>
        public List<string> CH16Side1PScratch{ get; set; }
        /// <summary>
        /// #xxx18 1p visible
        /// </summary>
        public List<string> CH18Side1PKey6 { get; set; }
        /// <summary>
        /// #xxx19 1p visible
        /// </summary>
        public List<string> CH19Side1PKey7 { get; set; }
        /// <summary>
        /// #xxx21 2p visible
        /// </summary>
        public List<string> CH21Side2PKey1 { get; set; }
        /// <summary>
        /// #xxx22 2p visible
        /// </summary>
        public List<string> CH22Side2PKey2 { get; set; }
        /// <summary>
        /// #xxx23 2p visible
        /// </summary>
        public List<string> CH23Side2PKey3 { get; set; }
        /// <summary>
        /// #xxx24 2p visible
        /// </summary>
        public List<string> CH24Side2PKey4 { get; set; }
        /// <summary>
        /// #xxx25 2p visible
        /// </summary>
        public List<string> CH25Side2PKey5 { get; set; }
        /// <summary>
        /// #xxx26 2p visible
        /// </summary>
        public List<string> CH26Side2PScratch { get; set; }
        /// <summary>
        /// #xxx28 2p visible
        /// </summary>
        public List<string> CH28Side2PKey6 { get; set; }
        /// <summary>
        /// #xxx29 2p visible
        /// </summary>
        public List<string> CH29Side2PKey7 { get; set; }
        /// <summary>
        /// #xxx31 1p invisible
        /// </summary>
        public List<string> CH31InvisibleSide1PKey1 { get; set; }
        /// <summary>
        /// #xxx32 1p invisible
        /// </summary>
        public List<string> CH32InvisibleSide1PKey2 { get; set; }
        /// <summary>
        /// #xxx33 1p invisible
        /// </summary>
        public List<string> CH33InvisibleSide1PKey3 { get; set; }
        /// <summary>
        /// #xxx34 1p invisible
        /// </summary>
        public List<string> CH34InvisibleSide1PKey4 { get; set; }
        /// <summary>
        /// #xxx35 1p invisible
        /// </summary>
        public List<string> CH35InvisibleSide1PKey5 { get; set; }
        /// <summary>
        /// #xxx36 1p invisible
        /// </summary>
        public List<string> CH36InvisibleSide1PScratch { get; set; }
        /// <summary>
        /// #xxx38 1p invisible
        /// </summary>
        public List<string> CH38InvisibleSide1PKey6 { get; set; }
        /// <summary>
        /// #xxx39 1p invisible
        /// </summary>
        public List<string> CH39InvisibleSide1PKey7 { get; set; }
        /// <summary>
        /// #xxx41 2p invisible
        /// </summary>
        public List<string> CH41InvisibleSide2PKey1 { get; set; }
        /// <summary>
        /// #xxx42 2p invisible
        /// </summary>
        public List<string> CH42InvisibleSide2PKey2 { get; set; }
        /// <summary>
        /// #xxx43 2p invisible
        /// </summary>
        public List<string> CH43InvisibleSide2PKey3 { get; set; }
        /// <summary>
        /// #xxx44 2p invisible
        /// </summary>
        public List<string> CH44InvisibleSide2PKey4 { get; set; }
        /// <summary>
        /// #xxx45 2p invisible
        /// </summary>
        public List<string> CH45InvisibleSide2PKey5 { get; set; }
        /// <summary>
        /// #xxx46 2p invisible
        /// </summary>
        public List<string> CH46InvisibleSide2PScratch { get; set; }
        /// <summary>
        /// #xxx48 2p invisible
        /// </summary>
        public List<string> CH48InvisibleSide2PKey6 { get; set; }
        /// <summary>
        /// #xxx49 2p invisible
        /// </summary>
        public List<string> CH49InvisibleSide2PKey7 { get; set; }
    }
}
