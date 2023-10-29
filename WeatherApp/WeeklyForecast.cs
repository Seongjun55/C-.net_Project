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
        private double lon;
        private double lat;
        private bool isCelsius;  // This flag determines the unit (Celsius or Fahrenheit)
        public WeeklyForecast(double lon, double lat)
        {
            InitializeComponent();
            this.lon = lon;
            this.lat = lat;
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
                try
                {
                    var json = web.DownloadString(url);
                    Console.WriteLine(json); // Output JSON data to the console for debugging
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
                        wkFUC.labRealTemp.Text = "Avg.Temp: " + ForecastInfo.daily[i].temp.day.ToString("0.0") + "°C";
                        wkFUC.labTemperature.Text = "Main weather: " + ForecastInfo.daily[i].weather[0].main.ToString();
                        wkFUC.labWindSpeed.Text = "Wind speed: "+ ForecastInfo.daily[i].wind_speed.ToString() + " m/s";
                        wkFUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;
                        //FlowLayoutPanel adds the User control into its element
                        weeklyFLP.Controls.Add(wkFUC);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the weekly weather data. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message); // Output any exception message to the console for debugging
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
