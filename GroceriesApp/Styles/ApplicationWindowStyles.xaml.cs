using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GroceriesApp.Styles
{
    public partial class ApplicationWindowStyles : ResourceDictionary
    {
        Window parentWindow;
        
        private void getWindow(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            parentWindow = border.Tag as Window;
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            parentWindow?.DragMove();
        }
    }
}
