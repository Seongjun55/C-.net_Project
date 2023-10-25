namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.Cloud = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labWeatherPrompt = new System.Windows.Forms.Label();
            this.labCloud = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.toggleCtoF = new System.Windows.Forms.Button();
            this.lstBoxSearchHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(179, 99);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(101, 67);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 31;
            this.picIcon.TabStop = false;
            // 
            // Cloud
            // 
            this.Cloud.AutoSize = true;
            this.Cloud.BackColor = System.Drawing.Color.Transparent;
            this.Cloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloud.ForeColor = System.Drawing.SystemColors.Window;
            this.Cloud.Location = new System.Drawing.Point(303, 328);
            this.Cloud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(53, 18);
            this.Cloud.TabIndex = 29;
            this.Cloud.Text = "Cloud:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.Window;
            this.labPressure.Location = new System.Drawing.Point(407, 291);
            this.labPressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(34, 18);
            this.labPressure.TabIndex = 28;
            this.labPressure.Text = "N/A";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.ForeColor = System.Drawing.SystemColors.Window;
            this.Pressure.Location = new System.Drawing.Point(303, 291);
            this.Pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(75, 18);
            this.Pressure.TabIndex = 27;
            this.Pressure.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.labWindSpeed.Location = new System.Drawing.Point(407, 253);
            this.labWindSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(34, 18);
            this.labWindSpeed.TabIndex = 26;
            this.labWindSpeed.Text = "N/A";
            // 
            // WindSpeed
            // 
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.WindSpeed.Location = new System.Drawing.Point(303, 253);
            this.WindSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(99, 18);
            this.WindSpeed.TabIndex = 25;
            this.WindSpeed.Text = "Wind Speed:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunset.Location = new System.Drawing.Point(142, 362);
            this.labSunset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(34, 18);
            this.labSunset.TabIndex = 24;
            this.labSunset.Text = "N/A";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.ForeColor = System.Drawing.SystemColors.Window;
            this.Sunset.Location = new System.Drawing.Point(77, 362);
            this.Sunset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(60, 18);
            this.Sunset.TabIndex = 23;
            this.Sunset.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunrise.Location = new System.Drawing.Point(142, 328);
            this.labSunrise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(34, 18);
            this.labSunrise.TabIndex = 22;
            this.labSunrise.Text = "N/A";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.ForeColor = System.Drawing.SystemColors.Window;
            this.Sunrise.Location = new System.Drawing.Point(77, 328);
            this.Sunrise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(65, 18);
            this.Sunrise.TabIndex = 21;
            this.Sunrise.Text = "Sunrise:";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.labDetails.Location = new System.Drawing.Point(77, 291);
            this.labDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(57, 18);
            this.labDetails.TabIndex = 20;
            this.labDetails.Text = "Details";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.labCondition.Location = new System.Drawing.Point(77, 253);
            this.labCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(75, 18);
            this.labCondition.TabIndex = 19;
            this.labCondition.Text = "Condition";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(326, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TBCity
            // 
            this.TBCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TBCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(159, 53);
            this.TBCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(149, 26);
            this.TBCity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "City:";
            // 
            // labWeatherPrompt
            // 
            this.labWeatherPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labWeatherPrompt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherPrompt.ForeColor = System.Drawing.SystemColors.Window;
            this.labWeatherPrompt.Location = new System.Drawing.Point(12, 169);
            this.labWeatherPrompt.Name = "labWeatherPrompt";
            this.labWeatherPrompt.Size = new System.Drawing.Size(485, 39);
            this.labWeatherPrompt.TabIndex = 0;
            this.labWeatherPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labCloud
            // 
            this.labCloud.AutoSize = true;
            this.labCloud.BackColor = System.Drawing.Color.Transparent;
            this.labCloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloud.ForeColor = System.Drawing.SystemColors.Window;
            this.labCloud.Location = new System.Drawing.Point(407, 328);
            this.labCloud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCloud.Name = "labCloud";
            this.labCloud.Size = new System.Drawing.Size(34, 18);
            this.labCloud.TabIndex = 33;
            this.labCloud.Text = "N/A";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.ForeColor = System.Drawing.SystemColors.Window;
            this.labTemp.Location = new System.Drawing.Point(407, 362);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(34, 18);
            this.labTemp.TabIndex = 34;
            this.labTemp.Text = "N/A";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.BackColor = System.Drawing.Color.Transparent;
            this.Temperature.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.ForeColor = System.Drawing.SystemColors.Window;
            this.Temperature.Location = new System.Drawing.Point(303, 362);
            this.Temperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(95, 18);
            this.Temperature.TabIndex = 35;
            this.Temperature.Text = "Temperature";
            // 
            // toggleCtoF
            // 
            this.toggleCtoF.BackColor = System.Drawing.Color.Transparent;
            this.toggleCtoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.toggleCtoF.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toggleCtoF.Location = new System.Drawing.Point(445, 348);
            this.toggleCtoF.Name = "toggleCtoF";
            this.toggleCtoF.Size = new System.Drawing.Size(61, 50);
            this.toggleCtoF.TabIndex = 36;
            this.toggleCtoF.Text = "Change Scale";
            this.toggleCtoF.UseVisualStyleBackColor = false;
            this.toggleCtoF.Click += new System.EventHandler(this.toggleCtoF_Click);
            // 
            // lstBoxSearchHistory
            // 
            this.lstBoxSearchHistory.FormattingEnabled = true;
            this.lstBoxSearchHistory.Location = new System.Drawing.Point(1, 53);
            this.lstBoxSearchHistory.Name = "lstBoxSearchHistory";
            this.lstBoxSearchHistory.Size = new System.Drawing.Size(120, 95);
            this.lstBoxSearchHistory.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 797);
            this.Controls.Add(this.lstBoxSearchHistory);
            this.Controls.Add(this.toggleCtoF);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.labCloud);
            this.Controls.Add(this.labWeatherPrompt);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.WindSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label Cloud;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label WindSpeed;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labWeatherPrompt;
        private System.Windows.Forms.Label labCloud;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Button toggleCtoF;
        private System.Windows.Forms.ListBox lstBoxSearchHistory;
    }
}

