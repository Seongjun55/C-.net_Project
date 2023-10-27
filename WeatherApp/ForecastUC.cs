using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class ForecastUC : UserControl
    {
        public ForecastUC()
        {
            InitializeComponent();
        }
        public string Date
        {
            set { labDate.Text = value; }
        }

        public string WeatherCondition
        {
            set { labWeatherCondition.Text = value; }
        }

        public string WeatherDescription
        {
            set { labWeatherDescription.Text = value; }
        }

        public string WeatherIcon
        {
            set { picWeatherIcon.ImageLocation = value; }
        }

        public string Temperature
        {
            set { labTemperature.Text = value; }
        }
    }
}
