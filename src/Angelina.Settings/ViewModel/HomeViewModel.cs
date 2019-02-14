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
using ReactiveUI;
using System;
using System.Reactive;
using System.Reactive.Linq;
using Angelina;

namespace Angelina.Settings.ViewModel
{
    public class HomeViewModel : ReactiveObject
    {
        public HomeViewModel()
        {
            StartCommand = ReactiveCommand
                .CreateFromObservable(ExecuteStartCommand);
        }

        public ReactiveCommand<Unit, Unit> StartCommand { get; set; }

        private IObservable<Unit> ExecuteStartCommand()
        {
            Program.Entry();
            return Observable.Return(Unit.Default);
        }
    }
}
