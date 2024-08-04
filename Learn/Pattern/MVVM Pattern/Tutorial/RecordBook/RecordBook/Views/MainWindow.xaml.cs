using RecordBook.Models;
using RecordBook.ViewModels;
using System.Windows;
using System.Windows.Controls;


namespace RecordBook
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;

            return user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}