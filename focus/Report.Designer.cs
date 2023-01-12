
namespace focus
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.rcDayStreak = new focus.Common.ReportCard();
            this.rcDaysAccessed = new focus.Common.ReportCard();
            this.rcHoursFocused = new focus.Common.ReportCard();
            this.reportLineChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // rcDayStreak
            // 
            this.rcDayStreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rcDayStreak.Info = "info label";
            this.rcDayStreak.Location = new System.Drawing.Point(412, 12);
            this.rcDayStreak.MyProperty = ((System.Drawing.Image)(resources.GetObject("rcDayStreak.MyProperty")));
            this.rcDayStreak.Name = "rcDayStreak";
            this.rcDayStreak.Numeric = "_ _";
            this.rcDayStreak.Picture = ((System.IO.MemoryStream)(resources.GetObject("rcDayStreak.Picture")));
            this.rcDayStreak.Size = new System.Drawing.Size(160, 100);
            this.rcDayStreak.TabIndex = 2;
            // 
            // rcDaysAccessed
            // 
            this.rcDaysAccessed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcDaysAccessed.Info = "info label";
            this.rcDaysAccessed.Location = new System.Drawing.Point(212, 12);
            this.rcDaysAccessed.MyProperty = ((System.Drawing.Image)(resources.GetObject("rcDaysAccessed.MyProperty")));
            this.rcDaysAccessed.Name = "rcDaysAccessed";
            this.rcDaysAccessed.Numeric = "_ _";
            this.rcDaysAccessed.Picture = ((System.IO.MemoryStream)(resources.GetObject("rcDaysAccessed.Picture")));
            this.rcDaysAccessed.Size = new System.Drawing.Size(160, 100);
            this.rcDaysAccessed.TabIndex = 1;
            // 
            // rcHoursFocused
            // 
            this.rcHoursFocused.Info = "info label";
            this.rcHoursFocused.Location = new System.Drawing.Point(12, 12);
            this.rcHoursFocused.MyProperty = ((System.Drawing.Image)(resources.GetObject("rcHoursFocused.MyProperty")));
            this.rcHoursFocused.Name = "rcHoursFocused";
            this.rcHoursFocused.Numeric = "_ _";
            this.rcHoursFocused.Picture = ((System.IO.MemoryStream)(resources.GetObject("rcHoursFocused.Picture")));
            this.rcHoursFocused.Size = new System.Drawing.Size(160, 100);
            this.rcHoursFocused.TabIndex = 0;
            // 
            // reportLineChart
            // 
            this.reportLineChart.Location = new System.Drawing.Point(12, 118);
            this.reportLineChart.Name = "reportLineChart";
            this.reportLineChart.Size = new System.Drawing.Size(560, 232);
            this.reportLineChart.TabIndex = 4;
            this.reportLineChart.Text = "cartesianChart1";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.reportLineChart);
            this.Controls.Add(this.rcDayStreak);
            this.Controls.Add(this.rcDaysAccessed);
            this.Controls.Add(this.rcHoursFocused);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.ReportCard rcHoursFocused;
        private Common.ReportCard rcDaysAccessed;
        private Common.ReportCard rcDayStreak;
        private LiveCharts.WinForms.CartesianChart reportLineChart;
    }
}