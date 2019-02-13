using System.Windows;
using System.Windows.Controls;
using Angelina;

namespace Angelina.Settings.View
{
    /// <summary>
    /// VideoSettingView.xaml の相互作用ロジック
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Program.Entry();
        }
    }
}
