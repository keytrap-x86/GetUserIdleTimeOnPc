using System;
using System.Threading;
using System.Windows;


namespace GetUserIdleTimeOnPc
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Stop touching the PC to see the IdleTime
            Thread.Sleep(10000);
            TimeSpan timespent = TimeSpan.FromMilliseconds(IdleTimeFinder.GetIdleTime());
            Console.WriteLine($"User was idle for : {timespent.TotalSeconds} + seconds");

        }
    }
}
