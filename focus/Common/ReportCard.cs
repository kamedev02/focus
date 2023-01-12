using focus.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace focus.Common
{
    public partial class ReportCard : UserControl
    {
        private bool isDragging;
        private Point dragStartPosition;

        public ReportCard()
        {
            InitializeComponent();
        }

        #region --- Properties ---

        public static ImageConverter converter = new ImageConverter();
        public static byte[] image = (byte[])converter.ConvertTo(Resources.clock_red, typeof(byte[]));
        private MemoryStream mr = new MemoryStream(image);

        private MemoryStream _picture;

        public Image MyProperty
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }

        public MemoryStream Picture
        {
            get { return _picture; }
            set { _picture = value ?? mr; picIcon.Image = Image.FromStream(_picture); }
        }

        public string Info
        {
            get { return lbInfo.Text; }
            set { lbInfo.Text = value; }
        }

        public string Numeric
        {
            get { return lbNumeric.Text; }
            set { lbNumeric.Text = value; }
        }

        #endregion --- Properties ---

        private void ReportCard_Load(object sender, EventArgs e)
        {
            int infoWidth = lbInfo.Width;
            int numericWidth = lbNumeric.Width;
            lbInfo.Location = new Point(142 - infoWidth, 66);
            lbNumeric.Location = new Point(142 - numericWidth, 25);
            picIcon.Location = new Point(15, 10);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Start dragging the control
            this.isDragging = true;
            this.dragStartPosition = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Check if the control is being dragged
            if (this.isDragging)
            {
                // Calculate the difference between the drag start position and the current mouse position
                int diffX = e.X - this.dragStartPosition.X;
                int diffY = e.Y - this.dragStartPosition.Y;

                // Move the control to its new position
                this.Left += diffX;
                this.Top += diffY;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Stop dragging the control
            this.isDragging = false;
        }
    }
}