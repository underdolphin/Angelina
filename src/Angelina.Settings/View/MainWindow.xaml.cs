using MahApps.Metro.Controls;

namespace Angelina.Settings.View
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            HamburgerMenu.SelectedIndex = 0;
        }

        private void HamburgerMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            HamburgerMenu.Content = e.ClickedItem;
            HamburgerMenu.IsPaneOpen = false;
        }

        private void HamburgerMenu_OptionsItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
