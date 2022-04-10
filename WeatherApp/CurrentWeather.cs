using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WeatherApp
{
    enum Units
    {
        standard,
        metric,
        imperial
    }


    internal class CurrentWeather
    {
        public string Weather { get; set; }
        
        public Units Units { get; set; }
        public Location GetLocation()
        {
            request = HttpWebRequest.Create(ipLocation + GetIP());
            response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                JObject obj = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                return new Location()
                {
                    City = (string)obj.GetValue("city"),
                    Longitude = (double)obj.GetValue("longitude"),
                    Latitude = (double)obj.GetValue("latitude")
                };
            }
        }
        
        public Weather GetWeather()
        {
            GetWeatherJson();
            Weather weather = new Weather();

            weather.Temperature = (int)this.WeatherJson["main"]["temp"];
                weather.FeelsLike = (int)this.WeatherJson["main"]["feels_like"];
                weather.Minimal = (int)this.WeatherJson["main"]["temp_min"];
                weather.Maximum = (int)this.WeatherJson["main"]["temp_max"];
                weather.Pressure = (int)this.WeatherJson["main"]["pressure"];
                weather.Humidity = (int)this.WeatherJson["main"]["humidity"];
                weather.WindSpeed = (double)this.WeatherJson["wind"]["speed"];
                weather.Statement = this.WeatherJson["weather"][0]["main"].ToString();
                weather.Description = this.WeatherJson["weather"][0]["description"].ToString();
            
            
            return weather;
            
        }

        protected void GetWeatherJson()
        {
            request = HttpWebRequest.Create(WeatherServiceUrl +
                "lat=" + GetLocation().Latitude.ToString() +
                "&lon=" + GetLocation().Longitude.ToString() +
                ApiKey +
                "&units=" + Units);
            response = request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                this.WeatherJson = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            }
        }
        protected string GetIP()
        {
            return new System.Net.WebClient().DownloadString(ipUrl);
        }
        private JObject WeatherJson;
        private WebRequest request;
        private WebResponse response;
        private string ipUrl= "https://api.ipify.org";
        private string ipLocation = "http://ipwhois.app/json/";
        private string ApiKey = "&appid=a89ee683cd808a650dde20a6be5241ee";
        private string WeatherServiceUrl = "https://api.openweathermap.org/data/2.5/weather?";
    }
}
