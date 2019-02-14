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
using Angelina.Lib.SettingsData;
using Newtonsoft.Json;
using System.IO;

namespace Angelina.Settings.Model
{
    public class ResourceSettingsModel
    {
        public ResourceSettingsData ReadSettingsData()
        {
            ResourceSettingsData settingsData = new ResourceSettingsData();
            if (File.Exists(Constants.ResourceSettingsFilePath))
            {
                var settingsText = File.ReadAllText(Constants.ResourceSettingsFilePath);
                settingsData = JsonConvert.DeserializeObject<ResourceSettingsData>(settingsText);
            }
            return settingsData;
        }
    }
}
