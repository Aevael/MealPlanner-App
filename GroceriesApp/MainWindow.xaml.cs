using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using GroceriesApp.View.Windows;

namespace GroceriesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string selectedItem;

        public string SelectedItem
        {
            get { return selectedItem; }
            set {
                    selectedItem = value;
                    OnPropertyChanged();
                }
        }


        public event PropertyChangedEventHandler? PropertyChanged;


        
        

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        
    }
}