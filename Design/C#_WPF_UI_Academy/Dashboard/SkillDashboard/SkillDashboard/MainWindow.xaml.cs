﻿using System.Windows;
using System.Windows.Input;


namespace SkillDashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left )
            {
                this.DragMove();
            }
        }
    }
}