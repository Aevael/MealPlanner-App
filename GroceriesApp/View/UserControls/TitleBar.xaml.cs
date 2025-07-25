using System.Windows;
using System.Windows.Controls;

namespace GroceriesApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        Window currentWindow = Window.GetWindow(this); 
        public TitleBar()
        {
            InitializeComponent();
            
        }

        

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

            currentWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (currentWindow.WindowState == WindowState.Normal)
            {
                currentWindow.WindowState = WindowState.Maximized;
            }
            else if (currentWindow.WindowState == WindowState.Maximized)
            {
                currentWindow.WindowState = WindowState.Normal;
            }
             
            
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            currentWindow.Close();
        }
    }
}
