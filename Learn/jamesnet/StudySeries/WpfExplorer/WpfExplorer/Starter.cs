﻿namespace WpfExplorer
{
    class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            App app = new();
            app.Run();
        }
    }
}
