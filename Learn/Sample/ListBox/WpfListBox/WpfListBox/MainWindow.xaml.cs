using System.Windows;

namespace WpfListBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;
        }

        public List<TodoItem> ITEMLIST { get; set; } = TodoItems.GetTodoItems();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LBX1.Items.Add(TBX1.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(LBX1.SelectedItem != null)
            {
                LBX1.Items.Remove(LBX1.SelectedItem);
            }
        }
    }

    public class TodoItems
    {
        public List<TodoItem> MYLIST { get; set; } = GetTodoItems();
        public static List<TodoItem> GetTodoItems()
        {
            var list = new List<TodoItem>();
            list.Add(new TodoItem() { NAME = "Whole Milk" });
            list.Add(new TodoItem() { NAME = "Whole Wheat" });
            list.Add(new TodoItem() { NAME = "Orange Juice" });
            return list;
        }  
    }

    public class TodoItem
    {
        public string NAME { get; set; }

        public override string ToString()
        {
            return this.NAME;
        }
    }
}