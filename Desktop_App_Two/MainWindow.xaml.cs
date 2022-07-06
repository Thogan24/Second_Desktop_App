using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Desktop_App_Two
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private string name = "";
        public MainWindow()
        {
            InitializeComponent();
            startclock();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString(); /// (@"hh\:mm")
        }

        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {
            name = MainTextBox.Text;

            NameLabel.Content = $"Hello, {name}. i HATE you."; /// Same thing as + name
            MessageBox.Show($"Hello, {name}. i HATE you.");
        }
    }
}
