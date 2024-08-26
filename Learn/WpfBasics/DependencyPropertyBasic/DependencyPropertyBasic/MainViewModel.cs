using CommunityToolkit.Mvvm.ComponentModel;


namespace DependencyPropertyBasic
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal _value1;
        [ObservableProperty]
        private decimal _value2;
        [ObservableProperty]
        private string _operator;

        public MainViewModel()
        {
            Value1 = 1000;
            Value2 = 2000;
            Operator = "-";
        }
    }
}
