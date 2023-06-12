using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MC_VER3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date;
            date = DateTime.Now;
            TxtClock.Text = date.ToLongTimeString() + "   " + "   " + date.ToLongDateString();
        }

        private async void Button_Close_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Opacity -= 0.1;
                await Task.Delay(2);
            }
            this.Close();
        }

        private void Button_Hide_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
