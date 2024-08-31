using System.Windows;

namespace WpfLanguageApp
{
    public partial class App : Application
    {
        private static Dictionary<string, ResourceDictionary> _languages;
        private static ResourceDictionary _currentLanguage;

        private static Dictionary<string, ResourceDictionary> _themes;
        private static ResourceDictionary _currentTheme;

        public App()
        {
            #region Languages
            ResourceDictionary korean = GetResource("Korean");
            ResourceDictionary english = GetResource("English");

            _languages = new();
            _languages.Add("KOR", korean);
            _languages.Add("ENG", english);
            #endregion

            #region Themes
            ResourceDictionary dark = GetResource("Dark");
            ResourceDictionary white = GetResource("White");

            _themes = new();
            _themes.Add("DAK", dark);
            _themes.Add("WHI", white);
            #endregion

            //_currentLanguage = korean;
            //Resources.MergedDictionaries.Add(korean);
        }

        private ResourceDictionary GetResource(string nation)
        {
            ResourceDictionary resource = new();
            resource.Source = new Uri($"/WpfLanguageApp;component/Themes/{nation}.xaml", UriKind.RelativeOrAbsolute);

            return resource;
        }

        internal static void SwitchLanguage(LanguageModel language)
        {
            App.Current.Resources.MergedDictionaries.Remove(_currentLanguage);
            App.Current.Resources.MergedDictionaries.Add(_languages[language.Code]);
        }

        internal static void SwitchTheme(ThemeModel theme)
        {
            App.Current.Resources.MergedDictionaries.Remove(_currentTheme);
            App.Current.Resources.MergedDictionaries.Add(_themes[theme.Code]);
        }
    }
}
