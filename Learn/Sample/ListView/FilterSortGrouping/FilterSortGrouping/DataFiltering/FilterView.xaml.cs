using System.Windows;

namespace FilterSortGrouping.DataFiltering
{
    public partial class FilterView : Window
    {
        User[] Users = new User[]
        {
            new User("Quintessa Fernandez", "South Korea", "Pending"),
            new User("Sharon Valdez", "India", "Pending"),
            new User("Misono", "Japan", "Pending"),
            new User("Saika", "Japan", "Complete"),
            new User("Hammett Ashley", "India", "Complete"),
            new User("Alden Holcomb", "United Status", "Complete"),
            new User("Stephanie Marsh", "United Status", "Pending"),
        };

        public FilterView()
        {
            InitializeComponent();

            MyList.ItemsSource = Users;

            //FilterBy.ItemsSource = new string[] { "Name", "Country", "Status" };
            FilterBy.ItemsSource = typeof(User).GetProperties().Select((o) => o.Name);
        }

        #region Filter Method
        public Predicate<object> GetFilter()
        {
            switch (FilterBy.SelectedItem as string)
            {
                case "Name":
                    return NameFilter;
                case "Country":
                    return CountryFilter;
                case "Status":
                    return StatusFilter;
            }

            return NameFilter;
        }

        private bool NameFilter(object obj)
        {
            var Filterobj = obj as User;

            return Filterobj.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }

        private bool CountryFilter(object obj)
        {
            var Filterobj = obj as User;

            return Filterobj.Country.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }

        private bool StatusFilter(object obj)
        {
            var Filterobj = obj as User;

            return Filterobj.Status.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
        #endregion


        #region EventHandler
        private void FilterBy_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(FilterTextBox.Text == null)
            {
                MyList.Items.Filter = null;
            }
            else
            {
                MyList.Items.Filter = GetFilter();
            }
        }

        private void FilterTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            MyList.Items.Filter = GetFilter();
        } 
        #endregion
    }
}
