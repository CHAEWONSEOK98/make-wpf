﻿using System.Windows;
using WpfDemo.Windows;

namespace WpfDemo
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new HamburgerMenuDemoWindow();
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
