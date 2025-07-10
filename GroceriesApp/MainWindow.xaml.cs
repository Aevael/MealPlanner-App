using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

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
            ObservableCollection<string> entries = new ObservableCollection<string>();
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

        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(input.InputText);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}