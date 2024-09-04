﻿using System.Windows;
using System.Windows.Controls;

namespace KakaoStudy.Friends.Favorites.UI.Units
{
    public class FavoriteBoxItem : ListBoxItem
    {
        static FavoriteBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FavoriteBoxItem), new FrameworkPropertyMetadata(typeof(FavoriteBoxItem)));
        }
    }
}
