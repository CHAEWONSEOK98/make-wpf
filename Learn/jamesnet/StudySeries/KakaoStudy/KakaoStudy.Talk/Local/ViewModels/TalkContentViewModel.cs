using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using KakaoStudy.Core.Interface;
using KakaoStudy.Core.Models;
using KakaoStudy.Core.Talking;
using System.Collections.ObjectModel;

namespace KakaoStudy.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase, IReceivedMessage, IReceiverInfo, IViewLoadable
    {
        private readonly ChatStorage _chatStorage;
        private FriendsModel _receiver;

        [ObservableProperty]
        private string _sendText;

        [ObservableProperty]
        private ObservableCollection<MessageModel> _chats;


        public TalkContentViewModel(ChatStorage chatStorage)
        {
            _chatStorage = chatStorage;
            SendText = "";

            Chats = new();
        }

        public void InitReceiver(FriendsModel data)
        {
            _receiver = data;
        }

        public void OnLoaded(IViewable smartWindow)
        {
            Chats = chatso
        }

        public void Receive(string receiveText)
        {
            var message = new MessageModel().DataGen("Receive", receiveText);
            Chats.Add(message);

            _chatStorage.Add(_receiver, message);
        }

        [RelayCommand]
        private void Send()
        {
            var message = new MessageModel().DataGen("Send", SendText);
            Chats.Add(message);
            _chatStorage.Add(_receiver, message);
            SendText = "";
        }
    }
}
