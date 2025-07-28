using GroceriesApp.View.UserControls;
using GroceriesApp.View.Windows;
using GroceriesApp.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace GroceriesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mRestoreIfMove = false;
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
            
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipeWindow = new RecipeWindow();
            recipeWindow.Show();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {

        }
    }
}