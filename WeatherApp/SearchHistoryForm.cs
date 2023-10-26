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
        //Create an Form1 object
        private Form1 mainWindowForm;
        public SearchHistoryForm(Form1 form)
        {
            InitializeComponent();
            //Store a reference of the main form into a variable
            mainWindowForm = form;
        }

        //Button that will perform a recall when user clicks on contents
        private void lstSearchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if user selects a city from the list
            if (lstSearchHistory.SelectedIndex != -1)
            {
                //Autofill the textbox in the main window to the selected item
                mainWindowForm.TBCity.Text = lstSearchHistory.SelectedItem.ToString();
            }
        }
    }
}
