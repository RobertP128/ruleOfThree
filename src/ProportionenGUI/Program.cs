using System;
using Gtk;

namespace ProportionenGUI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mono.Unix.Catalog.Init("i8n1", "./locale");
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
