using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeeklyForecast : Form
    {

        string APIKey = "18dede3a5891aa7f0c4f991203e451c0";
        double lon;
        double lat;
        private bool isCelsius;  // This flag determines the unit (Celsius or Fahrenheit)
        public WeeklyForecast()
        {
            InitializeComponent();
            getWeeklyForecast();
        }

        void getWeeklyForecast()
        {
            using (WebClient web = new WebClient())
            {
                //Clears the existing forecast
                weeklyFLP.Controls.Clear();
                //Loads the data from the link
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}&units=metric", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
                //Create a new instance of User control to display the hourly weather
                WeeklyForecastUC wkFUC;


                //goes through the week
                for (int i = 0; i < 8; i++)
                {
                    //Create new object of Forecast User Control 
                    wkFUC = new WeeklyForecastUC();
                    //Set up the required data the User control requires
                    wkFUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    wkFUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    wkFUC.labTemperature.Text = ForecastInfo.daily[i].weather[0].main.ToString();
                    wkFUC.labWindSpeed.Text = ForecastInfo.daily[i].wind_speed.ToString() + " m/s";
                    wkFUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;
                    //FlowLayoutPanel adds the User control into its element
                    weeklyFLP.Controls.Add(wkFUC);
                }
            }
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

    }
}
