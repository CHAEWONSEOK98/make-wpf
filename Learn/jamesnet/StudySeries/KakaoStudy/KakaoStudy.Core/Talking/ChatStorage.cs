using KakaoStudy.Core.Models;

namespace KakaoStudy.Core.Talking
{
    public class ChatStorage
    {
        private Dictionary<FriendsModel, List<MessageModel>> _chatHistory;
        public void Add(FriendsModel _receiver, MessageModel message)
        {
            if(!_chatHistory.ContainsKey(_receiver))
            {
                _chatHistory.Add(_receiver, new());
            }
            _chatHistory[_receiver].Add(message);
        }
    }
}
