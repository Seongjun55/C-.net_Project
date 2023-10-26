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
    public partial class SearchHistoryForm : Form
    {
        private Form1 mainWindowForm;
        public SearchHistoryForm(Form1 form)
        {
            InitializeComponent();
            mainWindowForm = form;
        }


        // Setter Method to set the value of TBCity TextBox in Search History


        private void lstSearchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchHistory.SelectedIndex != -1)
            {
                mainWindowForm.TBCity.Text = lstSearchHistory.SelectedItem.ToString();
            }
        }
    }
}
