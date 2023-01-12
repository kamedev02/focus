
namespace focus.Common
{
    partial class ReportCard
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
            this.roundPanel = new focus.Common.RoundPanel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbNumeric = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.roundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel
            // 
            this.roundPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.roundPanel.Controls.Add(this.lbInfo);
            this.roundPanel.Controls.Add(this.lbNumeric);
            this.roundPanel.Controls.Add(this.picIcon);
            this.roundPanel.Location = new System.Drawing.Point(0, 0);
            this.roundPanel.Name = "roundPanel";
            this.roundPanel.Radius = 20;
            this.roundPanel.Size = new System.Drawing.Size(160, 100);
            this.roundPanel.TabIndex = 0;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbInfo.Location = new System.Drawing.Point(3, 70);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInfo.Size = new System.Drawing.Size(140, 16);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "info label";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumeric
            // 
            this.lbNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNumeric.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbNumeric.Location = new System.Drawing.Point(74, 25);
            this.lbNumeric.Name = "lbNumeric";
            this.lbNumeric.Size = new System.Drawing.Size(69, 20);
            this.lbNumeric.TabIndex = 1;
            this.lbNumeric.Text = "_ _";
            this.lbNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::focus.Properties.Resources.clock_red;
            this.picIcon.Location = new System.Drawing.Point(15, 10);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(35, 35);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundPanel);
            this.Name = "ReportCard";
            this.Size = new System.Drawing.Size(160, 100);
            this.Load += new System.EventHandler(this.ReportCard_Load);
            this.roundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbNumeric;
        private System.Windows.Forms.PictureBox picIcon;
    }
}
