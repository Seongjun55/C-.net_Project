namespace WeatherApp
{
    partial class SearchHistoryForm
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
            this.lstSearchHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstSearchHistory
            // 
            this.lstSearchHistory.FormattingEnabled = true;
            this.lstSearchHistory.Location = new System.Drawing.Point(64, 48);
            this.lstSearchHistory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstSearchHistory.Name = "lstSearchHistory";
            this.lstSearchHistory.Size = new System.Drawing.Size(91, 134);
            this.lstSearchHistory.TabIndex = 0;
            this.lstSearchHistory.SelectedIndexChanged += new System.EventHandler(this.lstSearchHistory_SelectedIndexChanged);
            // 
            // SearchHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 251);
            this.Controls.Add(this.lstSearchHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SearchHistoryForm";
            this.Text = "SearchHistoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lstSearchHistory;
    }
}