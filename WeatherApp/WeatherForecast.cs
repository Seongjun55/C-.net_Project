using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherApp.WeatherForecast;

namespace WeatherApp
{
    class WeatherForecast
    {

        public class daily
        {
            public long dt { get; set; }
            public Temp temp { get; set; }
            public List<weather> weather { get; set; }
            public double wind_speed { get; set; }

        }
        public class Temp
        {
            public double day { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double night { get; set; }
            public double eve { get; set; }
            public double morn { get; set; }
        }
        public class hourly
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public double feelslike { get; set; }
            public double wind_speed { get; set; }
            public List<weather> weather { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        
        public class ForecastInfo
        {
            public List<hourly> hourly { get; set; }
            public List<daily> daily { get; set; }
            
            public List<Temp> temp { get; set; }
        }
    }
}