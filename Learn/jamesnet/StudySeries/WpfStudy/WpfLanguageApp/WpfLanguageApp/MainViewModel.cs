
using CommunityToolkit.Mvvm.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace WpfLanguageApp
{
    public class MainViewModel : ObservableObject
    {
        private LanguageModel _languageModel;

        public List<LanguageModel> Languages { get; set; }

        public LanguageModel Language
        {
            get => _languageModel;
            set => SetProperty2(ref _languageModel, value, LanguageModelChanged);
        }

        public MainViewModel()
        {
            Languages = GetLanguages();
            Language = Languages.FirstOrDefault();
        }

        private List<LanguageModel>? GetLanguages()
        {
            List<LanguageModel> source = new();
            source.Add(new LanguageModel().DataGen("KOR", "Korean"));
            source.Add(new LanguageModel().DataGen("ENG", "English"));
            return source;
        }

        private void LanguageModelChanged(LanguageModel value)
        {
            App.SwitchLanguage(value);
        }

        private void SetProperty2<T>(ref T value1, T value2, Action<T> changed, [CallerMemberName] string name = null)
        {
            OnPropertyChanged(name);
            value1 = value2;
            changed.Invoke(value2);
        }
    }
}
