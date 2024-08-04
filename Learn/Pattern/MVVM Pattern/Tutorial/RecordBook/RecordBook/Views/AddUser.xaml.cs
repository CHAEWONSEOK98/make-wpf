using RecordBook.ViewModels;
using System.Windows;


namespace RecordBook.Views
{
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }
    }
}
