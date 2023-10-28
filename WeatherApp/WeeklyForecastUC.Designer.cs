namespace WeatherApp
{
    partial class WeeklyForecastUC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.ForeColor = System.Drawing.Color.Black;
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.BackColor = System.Drawing.Color.Transparent;
            this.labWeatherDescription.ForeColor = System.Drawing.Color.Black;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            // 
            // labDT
            // 
            this.labDT.BackColor = System.Drawing.Color.Transparent;
            this.labDT.ForeColor = System.Drawing.Color.Black;
            // 
            // labTemperature
            // 
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.ForeColor = System.Drawing.Color.Black;
            // 
            // WeeklyForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::WeatherApp.Properties.Resources.forecastbg;
            this.Name = "WeeklyForecastUC";
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
