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
            this.labCloud = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(118, 120);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(135, 77);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 31;
            this.picIcon.TabStop = false;
            // 
            // labCloud
            // 
            this.labCloud.AutoSize = true;
            this.labCloud.BackColor = System.Drawing.Color.Transparent;
            this.labCloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloud.ForeColor = System.Drawing.SystemColors.Window;
            this.labCloud.Location = new System.Drawing.Point(549, 307);
            this.labCloud.Name = "labCloud";
            this.labCloud.Size = new System.Drawing.Size(42, 23);
            this.labCloud.TabIndex = 30;
            this.labCloud.Text = "N/A";
            // 
            // Cloud
            // 
            this.Cloud.AutoSize = true;
            this.Cloud.BackColor = System.Drawing.Color.Transparent;
            this.Cloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloud.ForeColor = System.Drawing.SystemColors.Window;
            this.Cloud.Location = new System.Drawing.Point(411, 307);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(66, 23);
            this.Cloud.TabIndex = 29;
            this.Cloud.Text = "Cloud:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.Window;
            this.labPressure.Location = new System.Drawing.Point(549, 264);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(42, 23);
            this.labPressure.TabIndex = 28;
            this.labPressure.Text = "N/A";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.ForeColor = System.Drawing.SystemColors.Window;
            this.Pressure.Location = new System.Drawing.Point(411, 264);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(95, 23);
            this.Pressure.TabIndex = 27;
            this.Pressure.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.labWindSpeed.Location = new System.Drawing.Point(549, 220);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(42, 23);
            this.labWindSpeed.TabIndex = 26;
            this.labWindSpeed.Text = "N/A";
            // 
            // WindSpeed
            // 
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.WindSpeed.Location = new System.Drawing.Point(411, 220);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(123, 23);
            this.WindSpeed.TabIndex = 25;
            this.WindSpeed.Text = "Wind Speed:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunset.Location = new System.Drawing.Point(196, 346);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(42, 23);
            this.labSunset.TabIndex = 24;
            this.labSunset.Text = "N/A";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.ForeColor = System.Drawing.SystemColors.Window;
            this.Sunset.Location = new System.Drawing.Point(109, 346);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(76, 23);
            this.Sunset.TabIndex = 23;
            this.Sunset.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunrise.Location = new System.Drawing.Point(196, 307);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(42, 23);
            this.labSunrise.TabIndex = 22;
            this.labSunrise.Text = "N/A";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.ForeColor = System.Drawing.SystemColors.Window;
            this.Sunrise.Location = new System.Drawing.Point(109, 307);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(81, 23);
            this.Sunrise.TabIndex = 21;
            this.Sunrise.Text = "Sunrise:";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.labDetails.Location = new System.Drawing.Point(109, 264);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(70, 23);
            this.labDetails.TabIndex = 20;
            this.labDetails.Text = "Details";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.labCondition.Location = new System.Drawing.Point(109, 220);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(91, 23);
            this.labCondition.TabIndex = 19;
            this.labCondition.Text = "Condition";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(393, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(170, 52);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(197, 30);
            this.TBCity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(114, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "City:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labCloud);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labCloud;
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
    }
}

