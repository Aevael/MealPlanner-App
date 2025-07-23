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

namespace GroceriesApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            // To implement: Windowstate binding
            /*if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            */
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            //Close();
        }
    }
}
