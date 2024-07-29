using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;


namespace KakaoTalk.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {

        // ObservableProperty : CommunityToolkit Attribute로 INotifyPropertyChanged 이벤트 호출이 추가된 Property를 자동으로 추가한다.
        [ObservableProperty]
        private INotifyPropertyChanged _currentViewModel;


        /*
         * RelayCommand
         * : Command를 간단하게 호출 할 수 있도록 도와주는 Attribute.
         * : 바인딩된 버튼이 클릭되면 메소드가 호출된다.
         */
        [RelayCommand] 
        public void ToLogin()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
        }

        [RelayCommand]
        public void ToChangePwd()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(ChangePwdControlViewModel))!;
        }

        [RelayCommand]
        public void ToSignup()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(SignupControlViewModel))!;
        }

        public MainViewModel()
        {
            _currentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
        }

        
    }
}
