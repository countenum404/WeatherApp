using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherWidget : Form
    {
        private Weather weather { get; set; }
        private CurrentWeather currentWeather { get; }
        public WeatherWidget()
        {
            InitializeComponent();
            currentWeather = new CurrentWeather();
            currentWeather.Units = Units.metric;
            UpdateWeatherData();
            
        }

        private void WidgetLoad(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                                                        System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private async void UpdateWeatherData()
        {
            weather = currentWeather.GetWeather();
            CurrentLocation.Text = currentWeather.GetLocation().City;
            Temperature.Text = weather.Temperature.ToString() + "°";
            await Task.Delay(1);
            Feels.Text = $"Feels like {weather.FeelsLike}" + "°";
            await Task.Delay(1);
            Statement.Text = weather.Statement;
            await Task.Delay(1);
            Description.Text = weather.Description;
            await Task.Delay(1);
            Max.Text = $"Max {weather.Maximum}" + "°";
            await Task.Delay(1);
            Min.Text = $"Min {weather.Minimal}" + "°";
            await Task.Delay(1);
            wspeed.Text = $"Wind {weather.WindSpeed}" + " m/s";
            await Task.Delay(1);
            pressure.Text = $"Pressure {weather.Pressure}";
            await Task.Delay(1);
        }

        private void WeatherIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            UpdateWeatherData();
            Thread.Sleep(200);
            this.WindowState = FormWindowState.Normal;
            this.Show();
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

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWeather.Units = Units.standard;
            UpdateWeatherData();
        }

        private void metricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWeather.Units = Units.metric;
            UpdateWeatherData();
        }

        private void imperialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWeather.Units = Units.imperial;
            UpdateWeatherData();
        }
    }
}
