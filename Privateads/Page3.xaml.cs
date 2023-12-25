using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Page3

{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                FilterItems();
                OnPropertyChanged();
            }
        }

        private List<string> allItems;
        public List<string> AllItems
        {
            get { return allItems; }
            set
            {
                allItems = value;
                FilterItems();
                OnPropertyChanged();
            }
        }

        private List<string> filteredItems;
        public List<string> FilteredItems
        {
            get { return filteredItems; }
            set
            {
                filteredItems = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            AllItems = new List<string>()
            {
                "Электроника",
                "Одежда",
                "Книги",
            };
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void FilterItems()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                FilteredItems = AllItems;
            }
            else
            {
                FilteredItems = new List<string>();

                foreach (string item in AllItems)
                {
                    if (item.ToLower().Contains(SearchText.ToLower()))
                    {
                        FilteredItems.Add(item);
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
