using GroceriesApp.Model;
using GroceriesApp.MVVM;
using System.Collections.ObjectModel;

namespace GroceriesApp.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase 
    {
        public MainWindowViewModel() { }

        public ObservableCollection<Recipe> Recipes { get; set; }

        private int selectedItem;

        

        public int SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        

        

    }      

     
    
}
