using System.Windows;


namespace DataBindingBasic
{
    public partial class MainWindow : Window
    {
        Person _person = new Person()
        {
            Name = "Jamie",
            Email = "Jamie@123.net",
            Address = "Wall Street",
            Number = 12345,
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = _person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{_person.Name}");
        }
    }

    class Person
    {
        public Person()
        {
            
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }
    }
}