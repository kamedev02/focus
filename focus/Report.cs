using focus.Common;
using focus.Properties;
using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace focus
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, System.EventArgs e)
        {
            rcHoursFocused.Info = "hours focused";
            rcHoursFocused.Picture = LoadPicTureIcon("hoursfocused");

            rcDaysAccessed.Info = "days accessed";
            rcDaysAccessed.Picture = LoadPicTureIcon("daysaccessed");

            rcDayStreak.Info = "day streak";
            rcDayStreak.Picture = LoadPicTureIcon("daystreak");

            CreateReport();
        }

        public MemoryStream LoadPicTureIcon(string icon)
        {
            ImageConverter converter = new ImageConverter();
            byte[] image;
            switch (icon)
            {
                case "hoursfocused":
                    image = (byte[])converter.ConvertTo(Resources.clock_red, typeof(byte[]));
                    break;

                case "daysaccessed":
                    image = (byte[])converter.ConvertTo(Resources.calender_red, typeof(byte[]));
                    break;

                case "daystreak":
                    image = (byte[])converter.ConvertTo(Resources.flame_red, typeof(byte[]));
                    break;

                default:
                    image = (byte[])converter.ConvertTo(Resources.clock_red, typeof(byte[]));
                    break;
            }

            MemoryStream mr = new MemoryStream(image);
            return mr;
        }

        private void CreateReport()
        {
            string executeFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(executeFolder, "data\\report.json");

            string json;
            using (StreamReader reader = new StreamReader(filePath))
            {
                json = reader.ReadToEnd();
            }

            // Deserialize the JSON string into a list of data points
            List<DataPoint> dataPoints = JsonConvert.DeserializeObject<List<DataPoint>>(json);
            var groups = dataPoints.GroupBy(x => x.Date).Reverse().Take(7).Reverse();

            double[] valuesFTime = new double[] { };
            double[] valuesBTime = new double[] { };
            string[] labelDate = new string[] { };

            foreach (var group in groups)
            {
                int focusTime = group.Sum(x => x.FocusTime);
                int breakTime = group.Sum(x => x.BreakTime);

                valuesFTime = valuesFTime.Concat(new double[] { Math.Round((Convert.ToDouble(focusTime) / 60), 2) }).ToArray();
                valuesBTime = valuesBTime.Concat(new double[] { Math.Round((Convert.ToDouble(breakTime) / 60), 2) }).ToArray();
                labelDate = labelDate.Concat(new string[] { group.Key }).ToArray();
            }

            double totalHours = valuesFTime.Sum();
            int totalDays = labelDate.Length;
            int totalStreak = CalculateStreak(labelDate);

            rcHoursFocused.Numeric = totalHours.ToString("00.00");
            rcDaysAccessed.Numeric = totalDays.ToString("00");
            rcDayStreak.Numeric = totalStreak.ToString("00");

            var FtimeCData = new ChartValues<double>();
            FtimeCData.AddRange(valuesFTime);

            var BtimeCData = new ChartValues<double>();
            BtimeCData.AddRange(valuesBTime);

            reportLineChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = labelDate
            });

            reportLineChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Hours",
            });

            reportLineChart.LegendLocation = LegendLocation.Right;

            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            series.Add(new LineSeries() { Title = "Focus Time", Values = FtimeCData });
            series.Add(new LineSeries() { Title = "Break Time", Values = BtimeCData });

            reportLineChart.Series = series;
        }

        private int CalculateStreak(string[] dates)
        {
            DateTime[] sortedDates = dates.Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)).OrderBy(d => d).ToArray();

            int currentStreak = 1;
            int longestStreak = 1;

            for (int i = 1; i < sortedDates.Length; i++)
            {
                if (sortedDates[i] == sortedDates[i - 1].AddDays(1))
                {
                    currentStreak++;
                }
                else
                {
                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }
                    currentStreak = 1;
                }
            }

            if (currentStreak > longestStreak)
            {
                longestStreak = currentStreak;
            }

            return currentStreak;
        }
    }
}