﻿using System.Windows;
using System.Windows.Controls;

namespace RegisterPage.UserControls
{
    /// <summary>
    /// MyTextBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public string Hint
        {
            get { return (string)GetValue(HintProperty);}
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(MyTextBox));
    }
}
