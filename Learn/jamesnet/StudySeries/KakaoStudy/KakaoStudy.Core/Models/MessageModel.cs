
using KakaoStudy.Core.Interface;

namespace KakaoStudy.Core.Models
{
    public class MessageModel : IMessage
    {
        public string Type { get; set; }
        public string Message { get; set; }

        public MessageModel DataGen(string type, string sendText)
        {
            Type = type;
            Message = sendText;

            return this;
        }
    }
}
