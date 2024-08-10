using DataContextDemo.MYFOLDER;
using System.Windows;

namespace DataContextDemo
{
    public partial class MainWindow : Window
    {
        //public string MyProperty { get; set; } = "John";
        //public int MyInt { get; set; } = 1;

        public MainWindow()
        {
            InitializeComponent();
            //Student student = new Student();
            //DataContext = student;

            //var employee = new Employee();
            //DataContext = employee;
        }
    }

    public class Student
    {
        public int Id { get; set; } = 3;
        public string Name { get; set; } = "Josh";
    }
}