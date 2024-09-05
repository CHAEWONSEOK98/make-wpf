using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;

namespace KakaoStudy.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase
    {
        [ObservableProperty]
        private string _sendText;

        public TalkContentViewModel()
        {
            SendText = "";
        }

        [RelayCommand]
        private void Send()
        {
            SendText = "";
        }
    }
}
