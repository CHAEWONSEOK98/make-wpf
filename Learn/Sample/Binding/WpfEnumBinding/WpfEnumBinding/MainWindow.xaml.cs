using System.Windows;

namespace WpfEnumBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    // example 1
    public enum Season
    {
        Winter, Spring, Summer, Fall
    }

    // example 2
    public enum Genre
    {
        History, Technology, Novel
    }
    public class Book
    {
        public string Title { get; set; }
        public Genre Genre { get; set;}
    }
    public class Books
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title="XMLDataProvider", Genre=Genre.History},
                new Book() {Title="Object Data Provider", Genre=Genre.Novel},
                new Book() {Title="Binding To Enums", Genre=Genre.Technology},
            }.ToList();
        }

        // example 3
        public static List<Book> GetBooks2(string booktype)
        {
            return new List<Book>()
            {
                new Book() {Title="XMLDataProvider", Genre=Genre.History},
                new Book() {Title="Object Data Provider", Genre=Genre.Novel},
                new Book() {Title="Binding To Enums", Genre=Genre.Technology},
            }.Where(book => book.Genre.ToString() == booktype).ToList();
        }
    }
}