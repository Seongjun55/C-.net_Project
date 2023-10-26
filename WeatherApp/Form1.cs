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
        List<String> searchHistory = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "8755aca3fcad3f0fa15174a40f901202";
        bool changeUnit = true;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();


        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string searchedCity = TBCity.Text.ToLower();
                    string tempUnit = changeUnit ? "metric" : "imperial";
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}", searchedCity, APIKey, tempUnit);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    // Call the method to add the search to the history
                    addToSearchHistory(searchedCity);
                    // Update UI elements and display weather prompts
                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labCondition.Text = Info.weather[0].main;
                    labDetails.Text = Info.weather[0].description;
                    labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                    labWindSpeed.Text = Info.wind.speed.ToString();
                    labCloud.Text = Info.clouds.all.ToString();
                    labPressure.Text = Info.main.pressure.ToString();
                    labTemp.Text = Info.main.temp.ToString();
                    weatherPrompts(Info.weather[0].main);
                }
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

        private void toggleCtoF_Click(object sender, EventArgs e)
        {
            //toggle between C and F unit
            changeUnit = !changeUnit;
            //Refresh weather data to display the change in unit
            getWeather();
        }


        //Update the listBox item to display the user's search history
        private void addToSearchHistory(string searchedCity)
        {
            //Checks for duplicates within the searched cities
            if (!searchHistory.Contains(searchedCity))
            {
                searchHistory.Insert(0, searchedCity);
                lstBoxSearchHistory.DataSource = null;
                lstBoxSearchHistory.DataSource = searchHistory;
            }
        }

        private List<string> GetSearchHistory()
        {
            return searchHistory;
        }

        private void clearSearchHistory()
        {
            searchHistory.Clear();
            lstBoxSearchHistory.DataSource = null;
        }

        private void lstBoxSearchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxSearchHistory.SelectedIndex != -1)
            {
                TBCity.Text = lstBoxSearchHistory.SelectedItem.ToString();
            }
        }
    }
}
