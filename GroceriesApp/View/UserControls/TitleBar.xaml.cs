using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace GroceriesApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {

        Window parentWindow;

        public TitleBar()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(TitleBar_Loaded);
        }
        
        private void TitleBar_Loaded(object sender, RoutedEventArgs e)
        {
            parentWindow = Window.GetWindow(this); 
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

            parentWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (parentWindow.WindowState == WindowState.Normal)
            {
                parentWindow.WindowState = WindowState.Maximized;
            }
            else if (parentWindow.WindowState == WindowState.Maximized)
            {
                parentWindow.WindowState = WindowState.Normal;
            }
             
            
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.Close();
        }
    }
}
