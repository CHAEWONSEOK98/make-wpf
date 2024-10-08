﻿using System.Windows;
using System.Windows.Controls;

namespace KakaoStudy.LayoutSupport.UI.Units
{
    public class PlaceholderTextBox : TextBox
    {
        public static readonly DependencyProperty PlaceholderTextProperty = 
            DependencyProperty.Register(nameof(PlaceholderText), typeof(string), typeof(PlaceholderTextBox), new PropertyMetadata(""));

        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }

        static PlaceholderTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlaceholderTextBox), new FrameworkPropertyMetadata(typeof(PlaceholderTextBox)));
        }
    }
}
