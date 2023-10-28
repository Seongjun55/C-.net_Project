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
            isCelsius = true; // Set Celsius as default
    }
        string APIKey = "18dede3a5891aa7f0c4f991203e451c0";
        List<string> searchHistory = new List<string>();
        double lon;
        double lat;
        private bool isCelsius;  // This flag determines the unit (Celsius or Fahrenheit)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    //Setting up which unit should be used.
                    string tempUnit = isCelsius ? "metric" : "imperial";

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

                    if (isCelsius)
                    {
                        labWindSpeed.Text = Info.wind.speed.ToString("0.##") + " m/s";
                    }
                    else
                    {
                        labWindSpeed.Text = (Info.wind.speed * 2.23694).ToString("0.##") + " mi/h";
                    }

                    labCloud.Text = Info.clouds.all.ToString() +"%";
                    labHumidity.Text = Info.main.humidity.ToString() +"%";
                    labTemp.Text = Math.Round(Info.main.temp).ToString() + (isCelsius ? "°C" : "°F");
                    labFeelsLike.Text = "Feels Like: " + Math.Round(Info.main.feels_like).ToString() + (isCelsius ? "°C" : "°F");

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

                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,daily,alerts&appid={2}&units=metric", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;
                for (int i = 0; i < 11; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.hourly[i].weather[0].icon + ".png";
                    FUC.labDT.Text = convertDateTime(ForecastInfo.hourly[i].dt).ToString("HH:mm");
                    FUC.labWindSpeed.Text = ForecastInfo.hourly[i].wind_speed.ToString() + (isCelsius ? " m/s" : " mi/h");
                    FUC.labWeatherDescription.Text = ForecastInfo.hourly[i].weather[0].description;
                    FUC.labTemperature.Text = ForecastInfo.hourly[i].temp.ToString("0.0") + "°C"; 

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
            // Convert the current displayed temperature
            double currentTemp = Convert.ToDouble(labTemp.Text.Substring(0, labTemp.Text.Length - 2)); // Removes the last two characters (either "°C" or "°F")

            if (isCelsius)
            {
                // Convert Celsius to Fahrenheit
                currentTemp = (currentTemp * 9 / 5) + 32;
                labTemp.Text = Math.Round(currentTemp).ToString() + "°F";
            }
            else
            {
                // Convert Fahrenheit to Celsius
                currentTemp = (currentTemp - 32) * 5 / 9;
                labTemp.Text = Math.Round(currentTemp).ToString() + "°C";
            }
            // Convert wind speed
            double currentWindSpeed = Convert.ToDouble(labWindSpeed.Text.Split(' ')[0]);

            if (isCelsius)
            {
                labWindSpeed.Text = (currentWindSpeed * 2.23694).ToString("0.##") + " mi/h";
            }
            else
            {
                labWindSpeed.Text = (currentWindSpeed / 2.23694).ToString("0.##") + " m/s";
            }

            // Toggle the flag
            isCelsius = !isCelsius;

            // Refresh weather data to display the change in unit
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
