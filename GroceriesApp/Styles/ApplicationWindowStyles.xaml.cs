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
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Border border = sender as Border;
            Window parentWindow = border.Tag as Window;
            parentWindow?.DragMove();
        }    
    }
}
