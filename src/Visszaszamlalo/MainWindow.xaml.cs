using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Visszaszamlalo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int sh;
        int sm;
        int ss;
        int h = 0;
        int m = 0;
        int s = 0;


        DispatcherTimer _timer;
        TimeSpan _time;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        string currentTime = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            #region óra, perc, másodperc fill
            cb_hour.Items.Add("0");
            cb_hour.Items.Add("1");
            cb_hour.Items.Add("2");
            cb_hour.Items.Add("3");
            cb_hour.Items.Add("4");
            cb_hour.Items.Add("5");
            cb_hour.Items.Add("6");
            cb_hour.Items.Add("7");
            cb_hour.Items.Add("8");
            cb_hour.Items.Add("9");
            cb_hour.Items.Add("10");
            cb_hour.Items.Add("11");
            cb_hour.Items.Add("12");
            cb_hour.Items.Add("13");
            cb_hour.Items.Add("14");
            cb_hour.Items.Add("15");
            cb_hour.Items.Add("16");
            cb_hour.Items.Add("17");
            cb_hour.Items.Add("18");
            cb_hour.Items.Add("19");
            cb_hour.Items.Add("20");
            cb_hour.Items.Add("21");
            cb_hour.Items.Add("22");
            cb_hour.Items.Add("23");
            cb_hour.Items.Add("24");
            cb_hour.Items.Add("25");
            cb_hour.Items.Add("26");
            cb_hour.Items.Add("27");
            cb_hour.Items.Add("28");
            cb_hour.Items.Add("29");
            cb_hour.Items.Add("30");
            cb_hour.Items.Add("31");
            cb_hour.Items.Add("32");
            cb_hour.Items.Add("33");
            cb_hour.Items.Add("34");
            cb_hour.Items.Add("35");
            cb_hour.Items.Add("36");
            cb_hour.Items.Add("37");
            cb_hour.Items.Add("38");
            cb_hour.Items.Add("39");
            cb_hour.Items.Add("40");
            cb_hour.Items.Add("41");
            cb_hour.Items.Add("42");
            cb_hour.Items.Add("43");
            cb_hour.Items.Add("44");
            cb_hour.Items.Add("45");
            cb_hour.Items.Add("46");
            cb_hour.Items.Add("47");
            cb_hour.Items.Add("48");
            cb_hour.Items.Add("49");
            cb_hour.Items.Add("50");
            cb_hour.Items.Add("51");
            cb_hour.Items.Add("52");
            cb_hour.Items.Add("53");
            cb_hour.Items.Add("54");
            cb_hour.Items.Add("55");
            cb_hour.Items.Add("56");
            cb_hour.Items.Add("57");
            cb_hour.Items.Add("58");
            cb_hour.Items.Add("59");

            cb_minute.Items.Add("0");
            cb_minute.Items.Add("1");
            cb_minute.Items.Add("2");
            cb_minute.Items.Add("3");
            cb_minute.Items.Add("4");
            cb_minute.Items.Add("5");
            cb_minute.Items.Add("6");
            cb_minute.Items.Add("7");
            cb_minute.Items.Add("8");
            cb_minute.Items.Add("9");
            cb_minute.Items.Add("10");
            cb_minute.Items.Add("11");
            cb_minute.Items.Add("12");
            cb_minute.Items.Add("13");
            cb_minute.Items.Add("14");
            cb_minute.Items.Add("15");
            cb_minute.Items.Add("16");
            cb_minute.Items.Add("17");
            cb_minute.Items.Add("18");
            cb_minute.Items.Add("19");
            cb_minute.Items.Add("20");
            cb_minute.Items.Add("21");
            cb_minute.Items.Add("22");
            cb_minute.Items.Add("23");
            cb_minute.Items.Add("24");
            cb_minute.Items.Add("25");
            cb_minute.Items.Add("26");
            cb_minute.Items.Add("27");
            cb_minute.Items.Add("28");
            cb_minute.Items.Add("29");
            cb_minute.Items.Add("30");
            cb_minute.Items.Add("31");
            cb_minute.Items.Add("32");
            cb_minute.Items.Add("33");
            cb_minute.Items.Add("34");
            cb_minute.Items.Add("35");
            cb_minute.Items.Add("36");
            cb_minute.Items.Add("37");
            cb_minute.Items.Add("38");
            cb_minute.Items.Add("39");
            cb_minute.Items.Add("40");
            cb_minute.Items.Add("41");
            cb_minute.Items.Add("42");
            cb_minute.Items.Add("43");
            cb_minute.Items.Add("44");
            cb_minute.Items.Add("45");
            cb_minute.Items.Add("46");
            cb_minute.Items.Add("47");
            cb_minute.Items.Add("48");
            cb_minute.Items.Add("49");
            cb_minute.Items.Add("50");
            cb_minute.Items.Add("51");
            cb_minute.Items.Add("52");
            cb_minute.Items.Add("53");
            cb_minute.Items.Add("54");
            cb_minute.Items.Add("55");
            cb_minute.Items.Add("56");
            cb_minute.Items.Add("57");
            cb_minute.Items.Add("58");
            cb_minute.Items.Add("59");

            cb_sec.Items.Add("0");
            cb_sec.Items.Add("1");
            cb_sec.Items.Add("2");
            cb_sec.Items.Add("3");
            cb_sec.Items.Add("4");
            cb_sec.Items.Add("5");
            cb_sec.Items.Add("6");
            cb_sec.Items.Add("7");
            cb_sec.Items.Add("8");
            cb_sec.Items.Add("9");
            cb_sec.Items.Add("10");
            cb_sec.Items.Add("11");
            cb_sec.Items.Add("12");
            cb_sec.Items.Add("13");
            cb_sec.Items.Add("14");
            cb_sec.Items.Add("15");
            cb_sec.Items.Add("16");
            cb_sec.Items.Add("17");
            cb_sec.Items.Add("18");
            cb_sec.Items.Add("19");
            cb_sec.Items.Add("20");
            cb_sec.Items.Add("21");
            cb_sec.Items.Add("22");
            cb_sec.Items.Add("23");
            cb_sec.Items.Add("24");
            cb_sec.Items.Add("25");
            cb_sec.Items.Add("26");
            cb_sec.Items.Add("27");
            cb_sec.Items.Add("28");
            cb_sec.Items.Add("29");
            cb_sec.Items.Add("30");
            cb_sec.Items.Add("31");
            cb_sec.Items.Add("32");
            cb_sec.Items.Add("33");
            cb_sec.Items.Add("34");
            cb_sec.Items.Add("35");
            cb_sec.Items.Add("36");
            cb_sec.Items.Add("37");
            cb_sec.Items.Add("38");
            cb_sec.Items.Add("39");
            cb_sec.Items.Add("40");
            cb_sec.Items.Add("41");
            cb_sec.Items.Add("42");
            cb_sec.Items.Add("43");
            cb_sec.Items.Add("44");
            cb_sec.Items.Add("45");
            cb_sec.Items.Add("46");
            cb_sec.Items.Add("47");
            cb_sec.Items.Add("48");
            cb_sec.Items.Add("49");
            cb_sec.Items.Add("50");
            cb_sec.Items.Add("51");
            cb_sec.Items.Add("52");
            cb_sec.Items.Add("53");
            cb_sec.Items.Add("54");
            cb_sec.Items.Add("55");
            cb_sec.Items.Add("56");
            cb_sec.Items.Add("57");
            cb_sec.Items.Add("58");
            cb_sec.Items.Add("59");
            #endregion


            if (!File.Exists("hatralevo_ido.txt"))
            {
                File.WriteAllText("hatralevo_ido.txt", "00:00:00");
            }
            else
            {
                File.WriteAllText("hatralevo_ido.txt", "Nincs elindított visszaszámlálás!");
            }


            if (!File.Exists("eltelt_ido.txt"))
            {
                File.WriteAllText("eltelt_ido.txt", "00:00:00");
            }
            else
            {
                sh = int.Parse(File.ReadAllText("eltelt_ido.txt").Split(':')[0]);
                sm = int.Parse(File.ReadAllText("eltelt_ido.txt").Split(':')[1]);
                ss = int.Parse(File.ReadAllText("eltelt_ido.txt").Split(':')[2]);

                lbl_stopper.Content = sh + ":" + sm + ":" + ss;
            }

            dispatcherTimer.Tick += new EventHandler(dt_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }


        void dt_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed + TimeSpan.FromSeconds(sh * 3600 + sm * 60 + ss);
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);
                lbl_stopper.Content = currentTime;

                File.WriteAllText("eltelt_ido.txt", currentTime);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_formatum.SelectedIndex == 0)
            {
                lbl_szamlalo.Content = h + ":" + m + ":" + s;
            }
        }

        private void cb_hour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            h = cb_hour.SelectedIndex;
            ComboBox_SelectionChanged(sender, e);
        }

        private void cb_minute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m = cb_minute.SelectedIndex;
            ComboBox_SelectionChanged(sender, e);
        }

        private void cb_sec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            s = cb_sec.SelectedIndex;
            ComboBox_SelectionChanged(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            int ido = h * 3600 + m * 60 + s;

            _time = TimeSpan.FromSeconds(ido);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                lbl_szamlalo.Content = _time.ToString("c");
                File.WriteAllText("hatralevo_ido.txt", _time.ToString("c"));
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sh = 0;
            sm = 0;
            ss = 0;
            stopWatch.Reset();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            stopWatch.Start();
            dispatcherTimer.Start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        private void btn_betolt_Click(object sender, RoutedEventArgs e)
        {
            if (!(tb_stopper_betolt.Text.Contains('H')) && !(tb_stopper_betolt.Text.Contains('M')) && !(tb_stopper_betolt.Text.Contains('S')))
            {
                sh = int.Parse(tb_stopper_betolt.Text.Split(':')[0]);
                sm = int.Parse(tb_stopper_betolt.Text.Split(':')[1]);
                ss = int.Parse(tb_stopper_betolt.Text.Split(':')[2]);

                lbl_stopper.Content = sh + ":" + sm + ":" + ss;
            }
        }
    }
}
