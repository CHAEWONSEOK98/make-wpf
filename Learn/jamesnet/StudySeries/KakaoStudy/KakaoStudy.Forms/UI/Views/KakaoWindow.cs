﻿using System.Windows;

namespace KakaoStudy.Forms.UI.Views
{
    public class KakaoWindow : Window
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }
    }
}