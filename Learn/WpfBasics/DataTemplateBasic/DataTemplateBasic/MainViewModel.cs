namespace DataTemplateBasic
{
    public class MainViewModel : ViewModelBase
    {
        private List<Student> students = default!;

        public MainViewModel()
        {
            students = Student.Students;
            CurrentViewModel = new TestViewModel();
        }

        public List<Student> Students { get => students; set { students = value; OnPropertyChanged(); } }
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
