using System;
using Gtk;

namespace ProportionenGUI
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {

            //Mono.Unix.Catalog.Init("i8n1", "./locale");

            Application.Init();

            var app = new Application("org.ProportionenGUI.ProportionenGUI", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();

        }
    }
}
