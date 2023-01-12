using focus.Common;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace focus
{
    public partial class frmMain : Form
    {
        public static CountDown mainCountdown = new CountDown();
        public static string execpath = System.Windows.Forms.Application.ExecutablePath;
        public static string pathresult = "";
        public static string pathconfig = "";
        public static bool isChildFormOpen = false;
        private frmFilter filter = new frmFilter();

        public frmMain()
        {
            InitializeComponent();
        }

        #region ===== System methods =====

        private void RegisterInStartup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.SetValue("Focus", System.Windows.Forms.Application.ExecutablePath);
        }

        private void UnRegisterInStartup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.DeleteValue("Focus");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            isChildFormOpen = false;
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    trayicon.Visible = true;
                    this.Hide();
                    trayicon.BalloonTipTitle = "Notification";
                    trayicon.BalloonTipText = "App is running in background\nRight click in tray icon to view options.";
                    trayicon.ShowBalloonTip(1000);
                    e.Cancel = true;
                    break;
            }
        }

        private void RunAsAdministrator()
        {
            if (!Program.IsAdministrator())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = pathresult;
                proc.FileName = Assembly.GetEntryAssembly().Location.Replace(".dll", ".exe");
                proc.Verb = "runas";
                try
                {
                    Process.Start(proc);
                    System.Windows.Forms.Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This program must be run as an administrator! \n\n" + ex.ToString());
                }
            }
        }

        private void ShowMes(object sender, EventArgs e)
        {
            MessageBox.Show("click");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                createReportFile();
                string[] execpathSplit = execpath.Split('\\');
                int execpathcount = execpathSplit.Length - 1;
                for (int i = 0; i < execpathcount; i++)
                {
                    pathresult += execpathSplit[i] + "\\";
                }

                pathconfig = pathresult + "config.ini";
                string showdialogstartup = INI.READ(pathconfig, "System", "ShowDialogStartup");
                string notificationsound = INI.READ(pathconfig, "System", "NotificationSound");
                string raa = INI.READ(pathconfig, "System", "RunAsAdministrator");
                if (raa == "true")
                {
                    RunAsAdministrator();
                }

                ////Load color to txtPreviewColor
                txtPreviewColor.BackColor = ColorTranslator.FromHtml(INI.READ(pathconfig, "Custom", "Color"));
                this.BackColor = ColorTranslator.FromHtml(INI.READ(pathconfig, "Custom", "Color"));
                string pathpreview = INI.READ(pathconfig, "Custom", "Image");
                if (File.Exists(pathpreview))
                {
                    picturePreview.Image = Image.FromFile(INI.READ(pathconfig, "Custom", "Image"));
                }
                colorForm.Color = ColorTranslator.FromHtml(INI.READ(pathconfig, "Custom", "Color"));

                //string curlang = INI.READ(pathconfig, "Setting", "Language");
                SetLanguageForComponent();
                SetCheckBoxComponent();
                numFocus.Value = Convert.ToDecimal(INI.READ(pathconfig, "Config", "Focustime"));

                if (showdialogstartup == "true")
                {
                    trayicon.Visible = false;
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    trayicon.Visible = true;
                    this.ShowInTaskbar = false;
                }

                if (notificationsound == "true")
                {
                    SystemSounds.Beep.Play();
                }
                trayicon.Text = "Focus v1.0.0";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SetFlagLanguage(string cur)
        {
            if (cur == "VI")
            {
                INI.WRITE(pathconfig, "Setting", "Language", "EN");
                INI.WRITE(pathconfig, "Setting", "Flag", "VI");
            }
            else
            {
                INI.WRITE(pathconfig, "Setting", "Language", "VI");
                INI.WRITE(pathconfig, "Setting", "Flag", "EN");
            }

            SetLanguageForComponent();
        }

        public void SetLanguageForComponent()
        {
            string flag = INI.READ(pathconfig, "Setting", "Flag");
            string pathLangImage = pathresult + "images\\" + flag + ".ico";
            ChangePictureBoxImage(Image.FromFile(pathLangImage));
            //set multi language for tabs control
            tabConfig.Text = Utility.GetLanguage("config", false);
            tabSystem.Text = Utility.GetLanguage("system", false);
            tabCustom.Text = Utility.GetLanguage("custom", false);
            tabOther.Text = Utility.GetLanguage("other", false);

            //set multi language for checkboxs
            chkRunAsAdmin.Text = Utility.GetLanguage("runasadministrator", false);
            chkRunWithWindows.Text = Utility.GetLanguage("runatboottime", false);
            chkShowForm.Text = Utility.GetLanguage("showatstartup", false);
            chkSoundNotification.Text = Utility.GetLanguage("notificationsound", false);

            //set multi language for labels
            lbFocustime.Text = Utility.GetLanguage("focustime", false);
            lbMinuteCon.Text = Utility.GetLanguage("minute", false);
            lbBreaktime.Text = Utility.GetLanguage("breaktime", false);
            lbRepeat.Text = Utility.GetLanguage("repeat", false);
            lbPreview.Text = Utility.GetLanguage("preview", false);

            //set multi language for buttons
            btnSetTime.Text = Utility.GetLanguage("settime", false);
            btnSetColor.Text = Utility.GetLanguage("setcolor", false);
            btnSaveColor.Text = Utility.GetLanguage("save", false);
            btnChangeImage.Text = Utility.GetLanguage("changewaitingwallpaper", false);

            //set multi language for tripMenu
            stripShowConfig.Text = Utility.GetLanguage("stripconfigshow", false);
            stripStart.Text = Utility.GetLanguage("stripstart", false);
            stripPause.Text = Utility.GetLanguage("strippause", false);
            stripStop.Text = Utility.GetLanguage("stripstop", false);
            stripExit.Text = Utility.GetLanguage("stripexit", false);
            setItemForSelect();
        }

        public void SetCheckBoxComponent()
        {
            chkRunAsAdmin.Checked = Convert.ToBoolean(INI.READ(pathconfig, "System", "RunAsAdministrator"));
            chkRunWithWindows.Checked = Convert.ToBoolean(INI.READ(pathconfig, "System", "RunAtBootTime"));
            chkShowForm.Checked = Convert.ToBoolean(INI.READ(pathconfig, "System", "ShowDialogStartup"));
            chkSoundNotification.Checked = Convert.ToBoolean(INI.READ(pathconfig, "System", "NotificationSound"));
        }

        private void createReportFile()
        {
            string executeFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(executeFolder, "data\\report.json");
            if (!Directory.Exists(executeFolder + "\\data"))
            {
                Directory.CreateDirectory(executeFolder + "\\data");
            }
            if (!File.Exists(filePath))
            {
                string json = JsonConvert.SerializeObject(new List<DataPoint>());

                // Create a new file and write the JSON string to it
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(json);
                }
            }
        }

        #endregion ===== System methods =====

        #region ===== Move Form ====

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion ===== Move Form ====

        #region ===== Set Checkbox Status =====

        private void chkRunAsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkChange("RunAsAdministrator", chkRunAsAdmin.Checked);
        }

        private void chkRunWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            checkChange("RunAtBootTime", chkRunWithWindows.Checked);
        }

        private void chkShowForm_CheckedChanged(object sender, EventArgs e)
        {
            checkChange("ShowDialogStartup", chkShowForm.Checked);
        }

        private void chkSoundNotification_CheckedChanged(object sender, EventArgs e)
        {
            checkChange("NotificationSound", chkSoundNotification.Checked);
        }

        public void checkChange(string key, bool value)
        {
            if (value)
            {
                INI.WRITE(pathconfig, "System", key, "true");
                if (key == "RunAtBootTime")
                {
                    RegisterInStartup();
                }
            }
            else
            {
                INI.WRITE(pathconfig, "System", key, "false");
                if (key == "RunAtBootTime")
                {
                    UnRegisterInStartup();
                }
            }
        }

        #endregion ===== Set Checkbox Status =====

        #region ===== Events =====

        private void trayicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayicon.Visible = false;
        }

        private void stripShowConfig_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            trayicon.Visible = false;
            //this.TopMost = true;
        }

        private void stripExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Utility.GetLanguage("quitconfirm", false),
                                        Utility.GetLanguage("quitcaption", false),
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trayicon.Visible = false;
                System.Windows.Forms.Application.Exit();
            }
        }

        private void ChangePictureBoxImage(Image image)
        {
            if (picLanguage.Image != null)
            {
                picLanguage.Image.Dispose();//dispose the old image.
            }
            picLanguage.Image = image;
            picLanguage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picLanguage_Click(object sender, EventArgs e)
        {
            string curlang = INI.READ(pathconfig, "Setting", "Language");
            SetFlagLanguage(curlang);
        }

        private void trayicon_MouseUp(object sender, MouseEventArgs e)
        {
            trayicon.Text = "Focus v1.0.0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Utility.GetLanguage("quitconfirm", false),
                                        Utility.GetLanguage("quitcaption", false),
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                trayicon.Visible = false;
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            trayicon.Visible = true;
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            trayicon.BalloonTipTitle = Utility.GetLanguage("traytitle", false);
            trayicon.BalloonTipText = Utility.GetLanguage("traycontent", false);
            trayicon.ShowBalloonTip(1000);
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            string focustime = numFocus.Value.ToString();
            string lbFocustime = Utility.GetLanguage("focustime", false);

            INI.WRITE(pathconfig, "Config", "Focustime", focustime);

            MessageBox.Show(lbFocustime + ": " + focustime);

            mainCountdown.Stop();
            lbCountDown.Text = "00:00:00";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string state = INI.READ(pathconfig, "Setting", "StartPause");

            if (state == "start")
            {
                mainCountdown.SetTime(Convert.ToInt32(INI.READ(pathconfig, "Config", "Focustime")), 0);
                mainCountdown.Start();
                if (mainCountdown.IsRunning)
                {
                    INI.WRITE(pathconfig, "Setting", "StartPause", "pause");
                    string imagepath = pathresult + "images\\" + INI.READ(pathconfig, "Setting", "StartPause") + ".ico";
                    btnStart.Image = Image.FromFile(imagepath);
                    btnSetTime.Enabled = false;
                    numFocus.Enabled = false;
                    cboBreaktime.Enabled = false;
                    cboRepeat.Enabled = false;
                }
                mainCountdown.TimeChanged += () =>
                {
                    lbCountDown.Text = mainCountdown.TimeLeftStr;
                    //trayicon.Text = mainCountdown.TimeLeftStr;
                };

                mainCountdown.CountDownFinished += () =>
                {
                    INI.WRITE(pathconfig, "Setting", "StartPause", "start");
                    btnStart.Image = Image.FromFile(pathresult + "images\\" + INI.READ(pathconfig, "Setting", "StartPause") + ".ico");
                    btnSetTime.Enabled = true;
                    numFocus.Enabled = true;
                    cboBreaktime.Enabled = true;
                    cboRepeat.Enabled = true;
                    mainCountdown.Stop();
                    frmFilter.onceSave = 0;
                    viewFilter();
                };

                mainCountdown.StepMs = 77;
            }
            else
            {
                btnSetTime.Enabled = true;
                numFocus.Enabled = true;
                cboBreaktime.Enabled = true;
                cboRepeat.Enabled = true;
                mainCountdown.Pause();
                INI.WRITE(pathconfig, "Setting", "StartPause", "start");
                string imagepath = pathresult + "images\\" + INI.READ(pathconfig, "Setting", "StartPause") + ".ico";
                btnStart.Image = Image.FromFile(imagepath);
                btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void FilterToggleImageButton(Bitmap image)
        {
            btnStart.Image = image;
            btnSetTime.Enabled = false;
            numFocus.Enabled = false;
            cboBreaktime.Enabled = false;
            cboRepeat.Enabled = false;
        }

        public void viewFilter()
        {
            // Nếu form con chưa được mở, thì mở form con
            if (!isChildFormOpen)
            {
                filter.Show();
                filter.OnChangeImage += FilterToggleImageButton;

                // Đánh dấu form con đã được mở
                isChildFormOpen = true;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        public void setItemForSelect()
        {
            //For Breaktime
            cboBreaktime.Items.Clear();
            cboBreaktime.Items.Add(new ComboBoxItem() { Text = Utility.GetLanguage("shortbreak", false), Value = 1 });
            cboBreaktime.Items.Add(new ComboBoxItem() { Text = Utility.GetLanguage("longbreak", false), Value = 2 });
            cboBreaktime.SelectedIndex = Convert.ToInt32(INI.READ(pathconfig, "Config", "BreakDefault"));

            //For Repeat
            cboRepeat.Items.Clear();
            cboRepeat.Items.Add(new ComboBoxItem() { Text = Utility.GetLanguage("once", false), Value = "once" });
            cboRepeat.Items.Add(new ComboBoxItem() { Text = Utility.GetLanguage("infinite", false), Value = "infinite" });
            cboRepeat.SelectedIndex = Convert.ToInt32(INI.READ(pathconfig, "Config", "RepeatDefault"));
        }

        private void cboBreaktime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboBreaktime.SelectedIndex;
            ComboBoxItem getval = (ComboBoxItem)cboBreaktime.SelectedItem;
            string val = getval.Value.ToString();

            INI.WRITE(pathconfig, "Config", "BreakDefault", index.ToString());
            INI.WRITE(pathconfig, "Config", "Breaktime", val);
        }

        private void cboRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboRepeat.SelectedIndex;
            ComboBoxItem getval = (ComboBoxItem)cboRepeat.SelectedItem;
            string val = getval.Value.ToString();

            INI.WRITE(pathconfig, "Config", "RepeatDefault", index.ToString());
            INI.WRITE(pathconfig, "Config", "Repeat", val);
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            colorForm.ShowDialog();
            txtPreviewColor.BackColor = colorForm.Color;
        }

        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            string color = ColorTranslator.ToHtml(colorForm.Color);
            INI.WRITE(pathconfig, "Custom", "Color", color);
            this.BackColor = ColorTranslator.FromHtml(INI.READ(pathconfig, "Custom", "Color"));
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Images(*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string currentPath = @"" + openFileDialog.FileName;
                string[] filesplit = currentPath.Split('\\');
                int count = filesplit.Length - 1;
                string filename = filesplit[count];

                string nextPath = @"images";
                if (!Directory.Exists(nextPath))
                {
                    Directory.CreateDirectory(nextPath);
                }
                nextPath = pathresult + nextPath + "\\" + filename;
                picturePreview.Image = Image.FromFile(currentPath);
                if (!File.Exists(nextPath))
                {
                    File.Copy(currentPath, nextPath);
                }

                INI.WRITE(pathconfig, "Custom", "Image", nextPath);
            }
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            frmTea tea = new frmTea();
            tea.Show();
        }

        private void tripStart_Click(object sender, EventArgs e)
        {
            mainCountdown.Start();
        }

        private void tripPause_Click(object sender, EventArgs e)
        {
            btnSetTime.Enabled = true;
            mainCountdown.Pause();
            INI.WRITE(pathconfig, "Setting", "StartPause", "start");
            string imagepath = pathresult + "images\\" + INI.READ(pathconfig, "Setting", "StartPause") + ".ico";
            btnStart.Image = Image.FromFile(imagepath);
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tripStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        public void StopTimer()
        {
            mainCountdown.Stop();
            numFocus.Enabled = true;
            btnSetTime.Enabled = true;
            cboBreaktime.Enabled = true;
            cboRepeat.Enabled = true;
            lbCountDown.Text = "00:00:00";
            trayicon.Text = "00:00:00";
            INI.WRITE(pathconfig, "Setting", "StartPause", "start");
            string imagepath = pathresult + "images\\" + INI.READ(pathconfig, "Setting", "StartPause") + ".ico";
            btnStart.Image = Image.FromFile(imagepath);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            reportProgress.Visible = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= reportProgress.Maximum; i++)
            {
                backgroundWorker.ReportProgress(i);
                System.Threading.Thread.Sleep(50);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            reportProgress.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
            reportProgress.Visible = false;
        }

        #endregion ===== Events =====
    }
}