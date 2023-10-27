namespace WeatherApp
{
    partial class ForecastControl
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
            this.pictWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDayTime = new System.Windows.Forms.Label();
            this.labWeatherCondition = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictWeatherIcon
            // 
            this.pictWeatherIcon.Location = new System.Drawing.Point(12, 12);
            this.pictWeatherIcon.Name = "pictWeatherIcon";
            this.pictWeatherIcon.Size = new System.Drawing.Size(88, 74);
            this.pictWeatherIcon.TabIndex = 0;
            this.pictWeatherIcon.TabStop = false;
            // 
            // labDayTime
            // 
            this.labDayTime.AutoSize = true;
            this.labDayTime.Location = new System.Drawing.Point(119, 12);
            this.labDayTime.Name = "labDayTime";
            this.labDayTime.Size = new System.Drawing.Size(60, 15);
            this.labDayTime.TabIndex = 1;
            this.labDayTime.Text = "Monday";
            this.labDayTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // labWeatherCondition
            // 
            this.labWeatherCondition.AutoSize = true;
            this.labWeatherCondition.Location = new System.Drawing.Point(119, 40);
            this.labWeatherCondition.Name = "labWeatherCondition";
            this.labWeatherCondition.Size = new System.Drawing.Size(49, 15);
            this.labWeatherCondition.TabIndex = 2;
            this.labWeatherCondition.Text = "Sunny";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Location = new System.Drawing.Point(119, 71);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(80, 15);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // ForecastControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labWeatherCondition);
            this.Controls.Add(this.labDayTime);
            this.Controls.Add(this.pictWeatherIcon);
            this.Name = "ForecastControl";
            this.Size = new System.Drawing.Size(349, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pictWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictWeatherIcon;
        public System.Windows.Forms.Label labDayTime;
        public System.Windows.Forms.Label labWeatherCondition;
        public System.Windows.Forms.Label labWeatherDescription;
    }
}
