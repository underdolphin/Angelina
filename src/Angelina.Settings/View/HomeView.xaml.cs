﻿/* Copyright 2018- underdolphin

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
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using Angelina.Settings.ViewModel;
using ReactiveUI;

namespace Angelina.Settings.View
{
    /// <summary>
    /// VideoSettingView.xaml の相互作用ロジック
    /// </summary>
    public partial class HomeView : UserControl, IViewFor<HomeViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(HomeViewModel), typeof(HomeView));

        public HomeView()
        {
            InitializeComponent();
            ViewModel = new HomeViewModel();

            this.WhenActivated(disposable =>
            {
                this.BindCommand(ViewModel, x => x.StartCommand, x => x.StartButton)
                    .DisposeWith(disposable);
            });
        }

        public HomeViewModel ViewModel
        {
            get => (HomeViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (HomeViewModel)value;
        }
    }
}
