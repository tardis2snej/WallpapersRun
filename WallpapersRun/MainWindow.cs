using System;
using System.IO;
using System.Windows.Forms;

namespace WallpapersRun
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            FillFormSettingsFields();
        }

        void FillFormSettingsFields()
        {
            wallpapersPathTextBox.Text = Properties.Settings1.Default.wallpapersPath;
            if (Properties.Settings1.Default.isDailyUpd)
                dailyUpdRadioButton.Checked = true;
            else
                intervalUpdRadioButton.Checked = true;
            TimeSpan interval = Properties.Settings1.Default.updInterval;
            hoursInterval.Value = interval.Hours + interval.Days * 24;
            minutesInterval.Value = interval.Minutes;
            nextUpdTimeLabel.Text = Properties.Settings1.Default.nextUpdTime.ToString();
        }


        private void openChoosePathDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = chooseFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
                wallpapersPathTextBox.Text = chooseFolderDialog.SelectedPath;
        }

        private void WallpapersPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(wallpapersPathTextBox.Text))
                pathWarningLabel.Visible = false;
            else
                pathWarningLabel.Visible = true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.wallpapersPath = wallpapersPathTextBox.Text;

            if (dailyUpdRadioButton.Checked)
                Properties.Settings1.Default.isDailyUpd = true;
            else if (intervalUpdRadioButton.Checked)
                Properties.Settings1.Default.isDailyUpd = false;

            Properties.Settings1.Default.updInterval = new TimeSpan(Convert.ToUInt16(hoursInterval.Value), Convert.ToUInt16(minutesInterval.Value), 00);
            Logic.SetNextUpdateTime();
            Logic.CreateSheduledTask();
            Properties.Settings1.Default.Save();
            FillFormSettingsFields();
            Program.Update();
        }

        private void NextWallpaperButton_Click(object sender, EventArgs e)
        {
            Win32.SetWallpaper(Logic.SelectNextWallpaper());
        }
    }
}
