namespace WeatherApp
{
    partial class ForecastUC
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
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDate = new System.Windows.Forms.Label();
            this.labWeatherCondition = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(16, 0);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(114, 147);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(157, 13);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(57, 15);
            this.labDate.TabIndex = 1;
            this.labDate.Text = "Sunday";
            // 
            // labWeatherCondition
            // 
            this.labWeatherCondition.AutoSize = true;
            this.labWeatherCondition.Location = new System.Drawing.Point(157, 88);
            this.labWeatherCondition.Name = "labWeatherCondition";
            this.labWeatherCondition.Size = new System.Drawing.Size(69, 15);
            this.labWeatherCondition.TabIndex = 2;
            this.labWeatherCondition.Text = "Condition";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Location = new System.Drawing.Point(157, 132);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(80, 15);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.Location = new System.Drawing.Point(157, 51);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(86, 15);
            this.labTemperature.TabIndex = 4;
            this.labTemperature.Text = "Temperature";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labWeatherCondition);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(565, 153);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDate;
        public System.Windows.Forms.Label labWeatherCondition;
        public System.Windows.Forms.Label labWeatherDescription;
        public System.Windows.Forms.Label labTemperature;
    }
}
