using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }

        private void HamburgerMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.HamburgerMenu.Content = e.ClickedItem;
            this.HamburgerMenu.IsPaneOpen = false;
        }

        private void HamburgerMenu_OptionsItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
