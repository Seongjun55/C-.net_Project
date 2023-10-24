using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;   

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "8755aca3fcad3f0fa15174a40f901202";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                //Initialse variable and use the URL for weather data retrieval
                //Uses city input from user and API key directly from openweathermap
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                // Download JSON data from the API
                var json = web.DownloadString(url);
                // Deserialize the JSON data into WeatherInfo.root object
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                // Update the UI elements with weather information
                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labWindSpeed.Text = Info.wind.speed.ToString();
                labCloud.Text = Info.clouds.all.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                // Call the method to display weather prompts
                weatherPrompts(Info.weather[0].main);
            }
        }

        void weatherPrompts (string labCondition)
        {
            switch (labCondition.ToLower()) {
                case "clear":
                    labWeatherPrompt.Text = "Beautiful day to go outside!";
                    break;
                case "clouds":
                    labWeatherPrompt.Text = "Perfect day to go outside!";
                    break;
                case "rain":
                    labWeatherPrompt.Text = "Bring an Umbrella!, chances of rain is high!";

                    break;
                case "thunderstorm":
                    labWeatherPrompt.Text = "Beware of thunderstorms!, chances of rain is present.";
                    break;
                case "snow":
                    labWeatherPrompt.Text = "Wear thick clothing today, i-it'll b-be c-cold t-today!";
                    break;
                case "mist":
                    labWeatherPrompt.Text = "Bring an Umbrella!, light showers and fog may occur.";
                    break;
                default:
                    labWeatherPrompt.Text = "Where is the weather?!";
                    break;
            
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
