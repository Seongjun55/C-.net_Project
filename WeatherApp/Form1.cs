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
        string APIKey = "18dede3a5891aa7f0c4f991203e451c0";
        bool changeUnit = true;
        List<string> searchHistory = new List<string>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    //Setting up which unit should be used.
                    string tempUnit = changeUnit ? "metric" : "imperial";

                    //Initialse variable and use the URL for weather data retrieval
                    //Uses city input from user and API key directly from openweathermap
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}", TBCity.Text, APIKey, tempUnit);

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
                    labTemp.Text = Info.main.temp.ToString();

                    lon = Info.coord.lon;
                    lat = Info.coord.lat;

                    // Call the method to display weather prompts
                    weatherPrompts(Info.weather[0].main);
                    string searchedCity = TBCity.Text.ToLower();

                    if (!searchHistory.Contains(searchedCity))
                    {
                        searchHistory.Add(searchedCity);
                    }

                }

                // Checking valid city from API
                catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
                {
                    // City not found on the API's server
                    MessageBox.Show("City not found. Please ensure you've entered a valid city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Other general errors
                    MessageBox.Show("An error occurred while fetching the weather data. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void getForecast()
        {
            
            using (WebClient web = new WebClient())
            {
                //Clears the existing forecast
                FLP.Controls.Clear();

                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;

                    FLP.Controls.Add(FUC);
                }
            }
        }
        void weatherPrompts(string labCondition)
        {
            //Switch case, when read weather condition, display accordingly
            switch (labCondition.ToLower())
            {
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
                    labWeatherPrompt.Text = $"Weather condition '{labCondition}' not recognized!";
                    break;

            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        private void toggleCtoF_Click(object sender, EventArgs e)
        {
            //toggle between C and F unit
            changeUnit = !changeUnit;
            //Refresh weather data to display the change in unit
            getWeather();
        }

        //Open the History of Search
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            //Create new object of history form
            SearchHistoryForm historyForm = new SearchHistoryForm(this);

            //append the user's query into the list box
            historyForm.lstSearchHistory.Items.AddRange(searchHistory.ToArray());
            //Display in new window the form
            historyForm.Show();
        }

    }
}
