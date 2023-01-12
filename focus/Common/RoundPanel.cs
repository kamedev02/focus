using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace focus.Common
{
    public class RoundPanel : Panel
    {
        private int radius;

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        public RoundPanel()
        {
            this.DoubleBuffered = true;
            this.radius = 20;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, this.radius, this.radius));
        }

        protected override void OnResize(EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, this.radius, this.radius));
            base.OnResize(e);
        }

        public int Radius
        {
            get { return this.radius; }
            set
            {
                this.radius = value;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, this.radius, this.radius));
            }
        }
    }
}