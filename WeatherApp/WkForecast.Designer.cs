namespace WeatherApp
{
    partial class WkForecast
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
            this.picWkIcon = new System.Windows.Forms.PictureBox();
            this.WkDay = new System.Windows.Forms.Label();
            this.WkTemp = new System.Windows.Forms.Label();
            this.WkWind = new System.Windows.Forms.Label();
            this.WkDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWkIcon
            // 
            this.picWkIcon.Location = new System.Drawing.Point(9, 22);
            this.picWkIcon.Name = "picWkIcon";
            this.picWkIcon.Size = new System.Drawing.Size(59, 105);
            this.picWkIcon.TabIndex = 0;
            this.picWkIcon.TabStop = false;
            // 
            // WkDay
            // 
            this.WkDay.AutoSize = true;
            this.WkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkDay.Location = new System.Drawing.Point(74, 22);
            this.WkDay.Name = "WkDay";
            this.WkDay.Size = new System.Drawing.Size(53, 16);
            this.WkDay.TabIndex = 1;
            this.WkDay.Text = "Sunday";
            // 
            // WkTemp
            // 
            this.WkTemp.AutoSize = true;
            this.WkTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkTemp.Location = new System.Drawing.Point(74, 57);
            this.WkTemp.Name = "WkTemp";
            this.WkTemp.Size = new System.Drawing.Size(85, 16);
            this.WkTemp.TabIndex = 2;
            this.WkTemp.Text = "Temperature";
            // 
            // WkWind
            // 
            this.WkWind.AutoSize = true;
            this.WkWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkWind.Location = new System.Drawing.Point(74, 84);
            this.WkWind.Name = "WkWind";
            this.WkWind.Size = new System.Drawing.Size(38, 16);
            this.WkWind.TabIndex = 3;
            this.WkWind.Text = "Wind";
            // 
            // WkDesc
            // 
            this.WkDesc.AutoSize = true;
            this.WkDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkDesc.Location = new System.Drawing.Point(74, 111);
            this.WkDesc.Name = "WkDesc";
            this.WkDesc.Size = new System.Drawing.Size(75, 16);
            this.WkDesc.TabIndex = 4;
            this.WkDesc.Text = "Description";
            // 
            // WkForecast
            // 
            this.Controls.Add(this.WkDesc);
            this.Controls.Add(this.WkWind);
            this.Controls.Add(this.WkTemp);
            this.Controls.Add(this.WkDay);
            this.Controls.Add(this.picWkIcon);
            this.Name = "WkForecast";
            this.Size = new System.Drawing.Size(176, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picWkIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label WkDay;
        public System.Windows.Forms.Label WkTemp;
        public System.Windows.Forms.Label WkWind;
        public System.Windows.Forms.Label WkDesc;
        public System.Windows.Forms.PictureBox picWkIcon;
    }
}
