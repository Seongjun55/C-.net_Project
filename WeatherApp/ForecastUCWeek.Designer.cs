namespace WeatherApp
{
    partial class ForecastUCWeek
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIconWeekly = new System.Windows.Forms.PictureBox();
            this.weekDT = new System.Windows.Forms.Label();
            this.weekMainWeather = new System.Windows.Forms.Label();
            this.weekWeatherDescription = new System.Windows.Forms.Label();
            this.weekTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIconWeekly)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIconWeekly
            // 
            this.picWeatherIconWeekly.Location = new System.Drawing.Point(10, 18);
            this.picWeatherIconWeekly.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picWeatherIconWeekly.Name = "picWeatherIconWeekly";
            this.picWeatherIconWeekly.Size = new System.Drawing.Size(55, 97);
            this.picWeatherIconWeekly.TabIndex = 0;
            this.picWeatherIconWeekly.TabStop = false;
            // 
            // weekDT
            // 
            this.weekDT.AutoSize = true;
            this.weekDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDT.Location = new System.Drawing.Point(69, 18);
            this.weekDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekDT.Name = "weekDT";
            this.weekDT.Size = new System.Drawing.Size(56, 17);
            this.weekDT.TabIndex = 1;
            this.weekDT.Text = "Sunday";
            // 
            // weekMainWeather
            // 
            this.weekMainWeather.AutoSize = true;
            this.weekMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekMainWeather.Location = new System.Drawing.Point(69, 45);
            this.weekMainWeather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekMainWeather.Name = "weekMainWeather";
            this.weekMainWeather.Size = new System.Drawing.Size(51, 17);
            this.weekMainWeather.TabIndex = 2;
            this.weekMainWeather.Text = "Cloudy";
            // 
            // weekWeatherDescription
            // 
            this.weekWeatherDescription.AutoSize = true;
            this.weekWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekWeatherDescription.Location = new System.Drawing.Point(69, 98);
            this.weekWeatherDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekWeatherDescription.Name = "weekWeatherDescription";
            this.weekWeatherDescription.Size = new System.Drawing.Size(79, 17);
            this.weekWeatherDescription.TabIndex = 3;
            this.weekWeatherDescription.Text = "Description";
            // 
            // weekTemperature
            // 
            this.weekTemperature.AutoSize = true;
            this.weekTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekTemperature.Location = new System.Drawing.Point(69, 72);
            this.weekTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekTemperature.Name = "weekTemperature";
            this.weekTemperature.Size = new System.Drawing.Size(90, 17);
            this.weekTemperature.TabIndex = 4;
            this.weekTemperature.Text = "Temperature";
            // 
            // ForecastUCWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weekTemperature);
            this.Controls.Add(this.weekWeatherDescription);
            this.Controls.Add(this.weekMainWeather);
            this.Controls.Add(this.weekDT);
            this.Controls.Add(this.picWeatherIconWeekly);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ForecastUCWeek";
            this.Size = new System.Drawing.Size(165, 137);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIconWeekly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label weekMainWeather;
        public System.Windows.Forms.Label weekWeatherDescription;
        public System.Windows.Forms.PictureBox picWeatherIconWeekly;
        public System.Windows.Forms.Label weekDT;
        public System.Windows.Forms.Label weekTemperature;
    }
}
