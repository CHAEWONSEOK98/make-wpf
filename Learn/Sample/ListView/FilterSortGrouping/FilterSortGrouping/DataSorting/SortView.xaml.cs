using System.Windows;
using System.ComponentModel;

namespace FilterSortGrouping.DataSorting
{
    public partial class SortView : Window
    {
        User[] Users = new User[]
        {
            new User("Alfonso", "Brazil", 21),
            new User("Madeson", "Brazil", 24),
            new User("Uriah", "France", 23),
            new User("Caroline", "Brazil", 24),
            new User("Elijah", "Brazil", 24),
            new User("Peter", "India", 22),
            new User("Evelyn", "France", 20),
            new User("Kimberley", "Brazil", 30),
            new User("Alex", "Italy", 26),
            new User("Myra", "France", 26),
            new User("Griffin", "India", 28),
            new User("Craig", "Sweden", 23),
            new User("Jillian", "France", 26),
            new User("Channing", "France", 21),
            new User("Shay", "Iaaly", 30),
            new User("Ben", "Sweden", 29),
            new User("Myles", "India", 27),
        };

        public SortView()
        {
            InitializeComponent();

            MyList.ItemsSource = Users;

            //SortBy.ItemsSource = new string[] { "Name", "Country", "Age" };
            SortBy.ItemsSource = typeof(User).GetProperties().Select((o) => o.Name);
            SortDir.ItemsSource = Enum.GetNames<ListSortDirection>();

            SortBy.SelectionChanged += SelectionChanged;
            SortDir.SelectionChanged += SelectionChanged;

            // 처음 실행했을 때 정렬되는 기준.
            MyList.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        public void SortList()
        {
            var SortProperty = SortBy.SelectedItem.ToString();
            var SortDirection = SortDir.SelectedItem.ToString() == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending;

            // 첫 실행 후 사용자가 선택한 값 Name, Country, Age | Ascending, Descending 에 따른 정렬.
            MyList.Items.SortDescriptions[0] = new SortDescription(SortProperty, SortDirection);
        }

        private void SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SortList();
        }
    }
}
