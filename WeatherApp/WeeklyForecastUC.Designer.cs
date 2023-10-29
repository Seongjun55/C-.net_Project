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
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.BackColor = System.Drawing.Color.Transparent;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            // 
            // labDT
            // 
            this.labDT.BackColor = System.Drawing.Color.Transparent;
            this.labDT.ForeColor = System.Drawing.Color.White;
            // 
            // labTemperature
            // 
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Size = new System.Drawing.Size(129, 22);
            this.labTemperature.Text = "Main weather";
            this.labTemperature.Click += new System.EventHandler(this.labTemperature_Click);
            // 
            // WeeklyForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.BackgroundImage = global::WeatherApp.Properties.Resources.forecastbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeeklyForecastUC";
            this.Size = new System.Drawing.Size(305, 158);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
