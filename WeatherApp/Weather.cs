using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class Weather
    {
        public int Temperature { get; set; }

        public int FeelsLike { get; set; }
        
        public int Pressure { get; set; }

        public int Humidity { get; set; }

        public int Minimal { get; set; }

        public int Maximum { get; set; }

        public double WindSpeed { get; set; }

        public string Statement { get; set; }

        public string Description { get; set; }
    }
}
