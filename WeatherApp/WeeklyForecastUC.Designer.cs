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
            this.labRealTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.Location = new System.Drawing.Point(92, 100);
            this.labWindSpeed.Size = new System.Drawing.Size(51, 22);
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.BackColor = System.Drawing.Color.Transparent;
            this.labWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.Location = new System.Drawing.Point(92, 122);
            this.labWeatherDescription.Size = new System.Drawing.Size(100, 22);
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.picWeatherIcon.Size = new System.Drawing.Size(73, 123);
            // 
            // labDT
            // 
            this.labDT.BackColor = System.Drawing.Color.Transparent;
            this.labDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.Color.White;
            this.labDT.Location = new System.Drawing.Point(92, 11);
            this.labDT.Size = new System.Drawing.Size(86, 25);
            // 
            // labTemperature
            // 
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.Location = new System.Drawing.Point(92, 74);
            this.labTemperature.Size = new System.Drawing.Size(117, 22);
            this.labTemperature.Text = "Main weather";
            this.labTemperature.Click += new System.EventHandler(this.labTemperature_Click);
            // 
            // labRealTemp
            // 
            this.labRealTemp.AutoSize = true;
            this.labRealTemp.BackColor = System.Drawing.Color.Transparent;
            this.labRealTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRealTemp.ForeColor = System.Drawing.Color.White;
            this.labRealTemp.Location = new System.Drawing.Point(92, 43);
            this.labRealTemp.Name = "labRealTemp";
            this.labRealTemp.Size = new System.Drawing.Size(92, 22);
            this.labRealTemp.TabIndex = 5;
            this.labRealTemp.Text = "Avg Temp";
            // 
            // WeeklyForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.BackgroundImage = global::WeatherApp.Properties.Resources.forecastbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labRealTemp);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeeklyForecastUC";
            this.Size = new System.Drawing.Size(311, 158);
            this.Controls.SetChildIndex(this.picWeatherIcon, 0);
            this.Controls.SetChildIndex(this.labDT, 0);
            this.Controls.SetChildIndex(this.labWindSpeed, 0);
            this.Controls.SetChildIndex(this.labWeatherDescription, 0);
            this.Controls.SetChildIndex(this.labTemperature, 0);
            this.Controls.SetChildIndex(this.labRealTemp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labRealTemp;
    }
}
