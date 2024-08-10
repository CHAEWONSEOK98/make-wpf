using System.Windows;

namespace WpfDataBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Student
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Chaegyul";
        public List<Book> Books { get; set; }

        public Student()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id=7, Title="Databinding In WPF"
                },
                new Book()
                {
                    Id=8, Title="DataContext In WPF"
                }
            };
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}