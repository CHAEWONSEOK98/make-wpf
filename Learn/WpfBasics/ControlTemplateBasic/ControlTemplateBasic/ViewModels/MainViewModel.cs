using ControlTemplateBasic.Models;

namespace ControlTemplateBasic
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Items = ComboItem.Items;
        }

        public List<ComboItem> Items { get; set; }
    }
}