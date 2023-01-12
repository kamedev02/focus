
using System.Windows.Forms;

namespace focus
{
    partial class frmFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilter));
            this.lbCountDown = new System.Windows.Forms.Label();
            this.pictureBreak = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCountDown
            // 
            this.lbCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.Location = new System.Drawing.Point(12, 9);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(164, 42);
            this.lbCountDown.TabIndex = 0;
            this.lbCountDown.Text = "00:00:00";
            // 
            // pictureBreak
            // 
            this.pictureBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBreak.Image = global::focus.Properties.Resources.spend;
            this.pictureBreak.Location = new System.Drawing.Point(0, 0);
            this.pictureBreak.Name = "pictureBreak";
            this.pictureBreak.Size = new System.Drawing.Size(750, 400);
            this.pictureBreak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBreak.TabIndex = 1;
            this.pictureBreak.TabStop = false;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.pictureBreak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilter";
            this.Opacity = 0.75D;
            this.Text = "Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.VisibleChanged += new System.EventHandler(this.frmFilter_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.PictureBox pictureBreak;
    }
}