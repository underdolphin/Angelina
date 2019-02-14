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
using Angelina.Settings.ViewModel;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;

namespace Angelina.Settings.View
{
    /// <summary>
    /// VideoSettingView.xaml の相互作用ロジック
    /// </summary>
    public partial class ResourcesSettingsView : UserControl, IViewFor<ResourceSettingsViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(ResourceSettingsViewModel), typeof(ResourcesSettingsView));

        public ResourcesSettingsView()
        {
            InitializeComponent();
            ViewModel = new ResourceSettingsViewModel();

            this.WhenActivated(disposable =>
            {
                this.BindCommand(ViewModel, x => x.AddCommand, x => x.AddButton)
                    .DisposeWith(disposable);
            });
        }

        public ResourceSettingsViewModel ViewModel
        {
            get => (ResourceSettingsViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ResourceSettingsViewModel)value;
        }
    }
}
