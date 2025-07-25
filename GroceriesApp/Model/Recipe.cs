using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceriesApp.Model
{
    internal class Recipe
    {
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public ObservableCollection<string> Steps { get; set; }
    }
}
