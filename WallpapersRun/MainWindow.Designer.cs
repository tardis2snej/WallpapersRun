namespace WallpapersRun
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wallpapersPathTextBox = new System.Windows.Forms.TextBox();
            this.chooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openChosePathDialog = new System.Windows.Forms.Button();
            this.pathWarningLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dailyUpdRadioButton = new System.Windows.Forms.RadioButton();
            this.intervalUpdRadioButton = new System.Windows.Forms.RadioButton();
            this.hoursInterval = new System.Windows.Forms.NumericUpDown();
            this.minutesInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nextUpdTimeLabel = new System.Windows.Forms.Label();
            this.nextWallpaperButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к папке, которая содержит обои";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файлы будут отображаться в алфавитном порядке; \r\nпапка должна содержать только из" +
    "ображения";
            // 
            // wallpapersPathTextBox
            // 
            this.wallpapersPathTextBox.AllowDrop = true;
            this.wallpapersPathTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wallpapersPathTextBox.Location = new System.Drawing.Point(28, 101);
            this.wallpapersPathTextBox.Name = "wallpapersPathTextBox";
            this.wallpapersPathTextBox.Size = new System.Drawing.Size(378, 33);
            this.wallpapersPathTextBox.TabIndex = 2;
            this.wallpapersPathTextBox.TextChanged += new System.EventHandler(this.WallpapersPathTextBox_TextChanged);
            // 
            // chooseFolderDialog
            // 
            this.chooseFolderDialog.ShowNewFolderButton = false;
            // 
            // openChosePathDialog
            // 
            this.openChosePathDialog.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openChosePathDialog.Location = new System.Drawing.Point(412, 101);
            this.openChosePathDialog.Name = "openChosePathDialog";
            this.openChosePathDialog.Size = new System.Drawing.Size(128, 33);
            this.openChosePathDialog.TabIndex = 3;
            this.openChosePathDialog.Text = "Открыть...";
            this.openChosePathDialog.UseVisualStyleBackColor = true;
            this.openChosePathDialog.Click += new System.EventHandler(this.openChoosePathDialog_Click);
            // 
            // pathWarningLabel
            // 
            this.pathWarningLabel.AutoSize = true;
            this.pathWarningLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathWarningLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pathWarningLabel.Location = new System.Drawing.Point(24, 137);
            this.pathWarningLabel.Name = "pathWarningLabel";
            this.pathWarningLabel.Size = new System.Drawing.Size(151, 24);
            this.pathWarningLabel.TabIndex = 4;
            this.pathWarningLabel.Text = "Некорректный путь";
            this.pathWarningLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Обновлять...";
            // 
            // dailyUpdRadioButton
            // 
            this.dailyUpdRadioButton.AutoSize = true;
            this.dailyUpdRadioButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dailyUpdRadioButton.Location = new System.Drawing.Point(28, 219);
            this.dailyUpdRadioButton.Name = "dailyUpdRadioButton";
            this.dailyUpdRadioButton.Size = new System.Drawing.Size(143, 33);
            this.dailyUpdRadioButton.TabIndex = 6;
            this.dailyUpdRadioButton.TabStop = true;
            this.dailyUpdRadioButton.Text = "Ежедневно в";
            this.dailyUpdRadioButton.UseVisualStyleBackColor = true;
            // 
            // intervalUpdRadioButton
            // 
            this.intervalUpdRadioButton.AutoSize = true;
            this.intervalUpdRadioButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalUpdRadioButton.Location = new System.Drawing.Point(28, 258);
            this.intervalUpdRadioButton.Name = "intervalUpdRadioButton";
            this.intervalUpdRadioButton.Size = new System.Drawing.Size(153, 33);
            this.intervalUpdRadioButton.TabIndex = 7;
            this.intervalUpdRadioButton.TabStop = true;
            this.intervalUpdRadioButton.Text = "Через каждые";
            this.intervalUpdRadioButton.UseVisualStyleBackColor = true;
            // 
            // hoursInterval
            // 
            this.hoursInterval.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursInterval.Location = new System.Drawing.Point(224, 238);
            this.hoursInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hoursInterval.Name = "hoursInterval";
            this.hoursInterval.Size = new System.Drawing.Size(77, 41);
            this.hoursInterval.TabIndex = 9;
            // 
            // minutesInterval
            // 
            this.minutesInterval.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutesInterval.Location = new System.Drawing.Point(376, 238);
            this.minutesInterval.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesInterval.Name = "minutesInterval";
            this.minutesInterval.Size = new System.Drawing.Size(76, 41);
            this.minutesInterval.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "час.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(466, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "мин.";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(383, 311);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(157, 42);
            this.ApplyButton.TabIndex = 13;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(24, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Время следующей смены обоев:";
            // 
            // nextUpdTimeLabel
            // 
            this.nextUpdTimeLabel.AutoSize = true;
            this.nextUpdTimeLabel.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextUpdTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nextUpdTimeLabel.Location = new System.Drawing.Point(110, 335);
            this.nextUpdTimeLabel.Name = "nextUpdTimeLabel";
            this.nextUpdTimeLabel.Size = new System.Drawing.Size(46, 24);
            this.nextUpdTimeLabel.TabIndex = 15;
            this.nextUpdTimeLabel.Text = "0000";
            // 
            // nextWallpaperButton
            // 
            this.nextWallpaperButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextWallpaperButton.Location = new System.Drawing.Point(12, 362);
            this.nextWallpaperButton.Name = "nextWallpaperButton";
            this.nextWallpaperButton.Size = new System.Drawing.Size(528, 55);
            this.nextWallpaperButton.TabIndex = 16;
            this.nextWallpaperButton.Text = "Следующие обои (независимо от настроек)";
            this.nextWallpaperButton.UseVisualStyleBackColor = true;
            this.nextWallpaperButton.Click += new System.EventHandler(this.NextWallpaperButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 429);
            this.Controls.Add(this.nextWallpaperButton);
            this.Controls.Add(this.nextUpdTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutesInterval);
            this.Controls.Add(this.hoursInterval);
            this.Controls.Add(this.intervalUpdRadioButton);
            this.Controls.Add(this.dailyUpdRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathWarningLabel);
            this.Controls.Add(this.openChosePathDialog);
            this.Controls.Add(this.wallpapersPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "WallpapersRun";
            ((System.ComponentModel.ISupportInitialize)(this.hoursInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wallpapersPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog chooseFolderDialog;
        private System.Windows.Forms.Button openChosePathDialog;
        private System.Windows.Forms.Label pathWarningLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton dailyUpdRadioButton;
        private System.Windows.Forms.RadioButton intervalUpdRadioButton;
        private System.Windows.Forms.NumericUpDown hoursInterval;
        private System.Windows.Forms.NumericUpDown minutesInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nextUpdTimeLabel;
        private System.Windows.Forms.Button nextWallpaperButton;
    }
}

