using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace SkillDashboard.UserControls
{
    public partial class Teammate : UserControl
    {
        public Teammate()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Teammate));

        public string Num
        {
            get { return (string)GetValue(NumProperty); }
            set { SetValue(NumProperty, value); }
        }
        public static readonly DependencyProperty NumProperty = DependencyProperty.Register("Num", typeof(string), typeof(Teammate));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Teammate));
    }
}
