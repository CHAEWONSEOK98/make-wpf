﻿using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkWindow : JamesWindow
    {

        public static DependencyProperty LocationProperty =
    DependencyProperty.Register("Location", typeof(object), typeof(DarkWindow), new PropertyMetadata());

        public object Location
        {
            get => (object)GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }

        public static DependencyProperty LocationTemplateProperty =
DependencyProperty.Register("LocationTemplate", typeof(DataTemplate), typeof(DarkWindow), new PropertyMetadata());

        public DataTemplate LocationTemplate
        {
            get => (DataTemplate)GetValue(LocationTemplateProperty);
            set => SetValue(LocationTemplateProperty, value);
        }

        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }

        public DarkWindow()
        {
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if(GetTemplateChild("PART_CloseButton") is Button button)
            {
                button.Click += (s, e) => { Close(); };
            }
        }
    }
}
