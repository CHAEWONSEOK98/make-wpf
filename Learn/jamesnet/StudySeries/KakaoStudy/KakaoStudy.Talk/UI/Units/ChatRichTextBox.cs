using KakaoStudy.LayoutSupport.UI.Units;
using KakaoStudy.Talk.TextMessage.UI.Units;
using System.Windows.Controls;

namespace KakaoStudy.Talk.UI.Units
{
    public class ChatRichTextBox : CustomRichTextBox
    {
        protected override Control GetContainerForItemOverride()
        {
            return new TextMessageItem();
        }
    }
}
