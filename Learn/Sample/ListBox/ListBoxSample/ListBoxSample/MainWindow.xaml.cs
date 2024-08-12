using System.Collections.ObjectModel;
using System.Windows;


namespace ListBoxSample
{
    public partial class MainWindow : Window
    {

        /*
         * private List<Person> list;
         * List 타입으로 데이터를 추가할 때 변화에 대한 것이 UI에 적용되지 않음.
         * 데이터를 추가해도 UI에 추가된 값이 나타나지 않는다.
         */

        /*
         * ObservableCollection
         * 변화를 UI에 알려주는 역할
         * 변화에 따른 데이터가 적용된 UI 확인 가능
         */
        private ObservableCollection<Person> list;

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new Person { IsChecked = false, Name = "우주", Age = 3 });
        }
        public MainWindow()
        {
            InitializeComponent();
            list = new ObservableCollection<Person>
            {
                new Person{IsChecked=true, Name="채귤", Age=27},
                new Person{IsChecked=true, Name="채연", Age=22},
                new Person{IsChecked=false, Name="채윤", Age=17},
                new Person{IsChecked=false, Name="채아", Age=25},
            };
            listBox.ItemsSource = list;
        }

        public class Person
        {
            public bool IsChecked { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}