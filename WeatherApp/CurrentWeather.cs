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
            Weather weather = new Weather()
            {
                Temperature = (int)this.WeatherJson["main"]["temp"],
                FeelsLike = (int)this.WeatherJson["main"]["feels_like"],
                Minimal = (int)this.WeatherJson["main"]["temp_min"],
                Maximum = (int)this.WeatherJson["main"]["temp_max"],
                Pressure = (int)this.WeatherJson["main"]["pressure"],
                Humidity = (int)this.WeatherJson["main"]["humidity"],
                Statement = (string)this.WeatherJson["weather"]["main"],
                Description = (string)this.WeatherJson["weather"]["description"]
            };
            
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
