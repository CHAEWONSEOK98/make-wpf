using System.Windows;
using System.Windows.Controls;

namespace WpfComboBox
{
    public partial class MainWindow : Window
    {
        public List<Student> students { get; set; } = Students.GetStudents();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cbo1.Items.Add(tbx1.Text);
        }

        private void SP2_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox cbo =  new ComboBox();
            //ComboBoxItem cbi = new ComboBoxItem();
            //cbi.Content = "Added dynamically";
            //cbo.Items.Add(cbi);
            List<string> itemlist = new List<string>()
            {
                "item 1",
                "item 2",
                "item 3",
            };
            cbo.ItemsSource = itemlist;
            SP2.Children.Add(cbo);
        }

        private void cboStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cbo = sender as ComboBox;
            var selectItem = cbo.SelectedItem as Student;
            lbxScores.Items.Clear();
            foreach (var score in selectItem.Scores)
            {
                lbxScores.Items.Add(score);
            }
        }
    }

    public class Students
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ Name="John", Scores=new List<int>(){1,2,3 } },
                new Student(){ Name="Jane", Scores=new List<int>(){3,4,5 } },
            };
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }
    }
}