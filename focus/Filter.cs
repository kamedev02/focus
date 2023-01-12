using focus.Common;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace focus
{
    public partial class frmFilter : Form
    {
        public static string pathconfig = Directory.GetCurrentDirectory() + "\\" + "config.ini";
        public static int onceSave = 0;

        public delegate void ChangeImage(Bitmap image);

        public event ChangeImage OnChangeImage;
        public frmFilter()
        {
            InitializeComponent();
            this.VisibleChanged += new EventHandler(frmFilter_VisibleChanged);
        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
            //Initial();
        }

        private void Initial()
        {
            //this.TopMost = true;
            CountDown timer = new CountDown();
            string pathimage = INI.READ(pathconfig, "Custom", "Image");
            if (File.Exists(pathimage))
            {
                pictureBreak.Image = Image.FromFile(pathimage);
            }
            int minute = Convert.ToInt32(INI.READ(pathconfig, "Config", "Breaktime"));
            timer.SetTime(minute, 0);
            timer.Start();
            timer.TimeChanged += () => lbCountDown.Text = timer.TimeLeftStr;
            timer.CountDownFinished += () =>
            {
                timer.Stop();
                if (onceSave < 1)
                {
                    updateReportFile();
                }

                if (INI.READ(pathconfig, "Config", "Repeat") == "infinite")
                {
                    frmMain.mainCountdown.Start();
                    INI.WRITE(pathconfig, "Setting", "StartPause", "pause");
                    OnChangeImage?.Invoke(Properties.Resources.pause);
                }
                frmMain.isChildFormOpen = false;
                this.Hide();
            };
            timer.StepMs = 77;
        }

        private void updateReportFile()
        {
            try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                string focustime = INI.READ(pathconfig, "Config", "Focustime");
                string breaktime = INI.READ(pathconfig, "Config", "Breaktime");
                string time = DateTime.Now.ToString("HH:mm:ss");


                string executeFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string filePath = Path.Combine(executeFolder, "data\\report.json");

                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                List<DataPoint> dataPoints = JsonConvert.DeserializeObject<List<DataPoint>>(json);

                dataPoints.Add(new DataPoint
                {
                    Date = date,
                    Time = time,
                    FocusTime = Convert.ToInt32(focustime),
                    BreakTime = Convert.ToInt32(breaktime)
                });

                json = JsonConvert.SerializeObject(dataPoints);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(json);
                }
                onceSave = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmFilter_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Initial();
            }
        }
    }
}