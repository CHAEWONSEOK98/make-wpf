﻿using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace KakaoStudy.Talk.UI.Views
{
    public class TalkContent : JamesContent
    {
        static TalkContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TalkContent), new FrameworkPropertyMetadata(typeof(TalkContent)));
        }
    }
}
