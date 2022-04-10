using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherWidget : Form
    {
        public WeatherWidget()
        {
            InitializeComponent();
            CurrentWeather currentWeather = new CurrentWeather();
            currentWeather.Units = Units.metric;
            CurrentLocation.Text = currentWeather.GetLocation().City;
            Temperature.Text = currentWeather.GetWeather().Temperature.ToString() + "°";
            label1.Text = currentWeather.GetWeather().FeelsLike.ToString();
            label2.Text = currentWeather.GetWeather().Statement;
            label3.Text = currentWeather.GetWeather().Description;
            label4.Text = currentWeather.GetWeather().Maximum.ToString();
            label5.Text = currentWeather.GetWeather().Minimal.ToString();
            label6.Text = currentWeather.GetWeather().WindSpeed.ToString();
            label7.Text = currentWeather.GetWeather().Pressure.ToString();
            
        }

        private void WidgetLoad(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                                                        System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void WeatherIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private async void FocusLost(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            await Task.Delay(10);
        }

        private void closeToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
