using System.Windows;
using System.Windows.Data;

namespace FilterSortGrouping.DataGrouping
{
    public partial class GroupView : Window
    {
        User[] users = new User[]
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

        public GroupView()
        {
            InitializeComponent();

            MyList.ItemsSource = users;
            GroupBy.ItemsSource = new string[] { "None", "Country", "Age" }; // 이름은 고유하기 때문에 Grouping 명단에서 제외.

       
        }

        public void GroupList()
        {
            MyList.Items.GroupDescriptions.Clear();
            var property = GroupBy.SelectedItem as string;

            if(property == "None")
            {
                return;
            }

            MyList.Items.GroupDescriptions.Add(new PropertyGroupDescription(property));
        }

        private void GroupBy_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            GroupList();
        }
    }
}
