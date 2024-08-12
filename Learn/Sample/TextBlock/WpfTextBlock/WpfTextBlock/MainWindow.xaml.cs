using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfTextBlock
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Blink();
        }

        void Blink()
        {
            // Create a Color Animation
            ColorAnimation animation = new ColorAnimation(Colors.White, Colors.Red, new Duration(new TimeSpan(100000)));
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;

            // Create SolidColorBrush
            SolidColorBrush scb = new SolidColorBrush();
            scb.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            // Add Text Effect
            TextEffect effect = new TextEffect();
            effect.PositionCount = 7; //int.MaxValue;
            effect.PositionStart = 0;
            effect.Foreground = scb;

            // Create TextBlock
            TextBlock tb = new TextBlock();
            tb.Text = "Blinking TextBlock";
            tb.FontSize = 65;
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.TextEffects = new TextEffectCollection();
            tb.TextEffects.Add(effect);
            myGrid.Children.Add(tb);
        }
    }
}