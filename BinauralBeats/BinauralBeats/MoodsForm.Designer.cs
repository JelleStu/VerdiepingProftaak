namespace BinauralBeats
{
    partial class MoodsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.rbMood1 = new System.Windows.Forms.RadioButton();
            this.rbMood2 = new System.Windows.Forms.RadioButton();
            this.rbMood3 = new System.Windows.Forms.RadioButton();
            this.rbMood4 = new System.Windows.Forms.RadioButton();
            this.rtbMoodInformation = new System.Windows.Forms.RichTextBox();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnMusicPause = new System.Windows.Forms.Button();
            this.dtpTimer = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblGoToProfile = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new AudioSpectrumAdvance.Spectrum();
            this.lblLogOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMood1
            // 
            this.rbMood1.AutoSize = true;
            this.rbMood1.Location = new System.Drawing.Point(20, 28);
            this.rbMood1.Margin = new System.Windows.Forms.Padding(2);
            this.rbMood1.Name = "rbMood1";
            this.rbMood1.Size = new System.Drawing.Size(76, 21);
            this.rbMood1.TabIndex = 1;
            this.rbMood1.TabStop = true;
            this.rbMood1.Text = "Mood 1";
            this.rbMood1.UseVisualStyleBackColor = true;
            this.rbMood1.CheckedChanged += new System.EventHandler(this.rbMood1_CheckedChanged);
            // 
            // rbMood2
            // 
            this.rbMood2.AutoSize = true;
            this.rbMood2.Location = new System.Drawing.Point(20, 62);
            this.rbMood2.Margin = new System.Windows.Forms.Padding(2);
            this.rbMood2.Name = "rbMood2";
            this.rbMood2.Size = new System.Drawing.Size(76, 21);
            this.rbMood2.TabIndex = 2;
            this.rbMood2.TabStop = true;
            this.rbMood2.Text = "Mood 2";
            this.rbMood2.UseVisualStyleBackColor = true;
            this.rbMood2.CheckedChanged += new System.EventHandler(this.rbMood2_CheckedChanged);
            // 
            // rbMood3
            // 
            this.rbMood3.AutoSize = true;
            this.rbMood3.Location = new System.Drawing.Point(20, 95);
            this.rbMood3.Margin = new System.Windows.Forms.Padding(2);
            this.rbMood3.Name = "rbMood3";
            this.rbMood3.Size = new System.Drawing.Size(76, 21);
            this.rbMood3.TabIndex = 3;
            this.rbMood3.TabStop = true;
            this.rbMood3.Text = "Mood 3";
            this.rbMood3.UseVisualStyleBackColor = true;
            this.rbMood3.CheckedChanged += new System.EventHandler(this.rbMood3_CheckedChanged);
            // 
            // rbMood4
            // 
            this.rbMood4.AutoSize = true;
            this.rbMood4.Location = new System.Drawing.Point(20, 129);
            this.rbMood4.Margin = new System.Windows.Forms.Padding(2);
            this.rbMood4.Name = "rbMood4";
            this.rbMood4.Size = new System.Drawing.Size(76, 21);
            this.rbMood4.TabIndex = 4;
            this.rbMood4.TabStop = true;
            this.rbMood4.Text = "Mood 4";
            this.rbMood4.UseVisualStyleBackColor = true;
            this.rbMood4.CheckedChanged += new System.EventHandler(this.rbMood4_CheckedChanged);
            // 
            // rtbMoodInformation
            // 
            this.rtbMoodInformation.Location = new System.Drawing.Point(236, 199);
            this.rtbMoodInformation.Margin = new System.Windows.Forms.Padding(2);
            this.rtbMoodInformation.Name = "rtbMoodInformation";
            this.rtbMoodInformation.Size = new System.Drawing.Size(304, 255);
            this.rtbMoodInformation.TabIndex = 6;
            this.rtbMoodInformation.Text = "";
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(232, 38);
            this.btnPlayMusic.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(122, 66);
            this.btnPlayMusic.TabIndex = 7;
            this.btnPlayMusic.Text = "Begin";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click_1);
            // 
            // btnMusicPause
            // 
            this.btnMusicPause.Location = new System.Drawing.Point(398, 38);
            this.btnMusicPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusicPause.Name = "btnMusicPause";
            this.btnMusicPause.Size = new System.Drawing.Size(108, 66);
            this.btnMusicPause.TabIndex = 8;
            this.btnMusicPause.Text = "Pauzeren";
            this.btnMusicPause.UseVisualStyleBackColor = true;
            this.btnMusicPause.Click += new System.EventHandler(this.btnMusicPause_Click);
            // 
            // dtpTimer
            // 
            this.dtpTimer.CustomFormat = "HH:mm:ss";
            this.dtpTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimer.Location = new System.Drawing.Point(354, 176);
            this.dtpTimer.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimer.Name = "dtpTimer";
            this.dtpTimer.ShowUpDown = true;
            this.dtpTimer.Size = new System.Drawing.Size(102, 22);
            this.dtpTimer.TabIndex = 9;
            this.dtpTimer.Value = new System.DateTime(2019, 11, 28, 0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 627);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(403, 107);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(593, 178);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(441, 663);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(133, 28);
            this.progressBar2.TabIndex = 12;
            this.progressBar2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(441, 627);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // lblGoToProfile
            // 
            this.lblGoToProfile.AutoSize = true;
            this.lblGoToProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToProfile.Location = new System.Drawing.Point(588, 21);
            this.lblGoToProfile.Name = "lblGoToProfile";
            this.lblGoToProfile.Size = new System.Drawing.Size(83, 28);
            this.lblGoToProfile.TabIndex = 15;
            this.lblGoToProfile.Text = "label1";
            this.lblGoToProfile.Click += new System.EventHandler(this.label1_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 492);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(785, 106);
            this.elementHost1.TabIndex = 10;
            this.elementHost1.Child = this.spectrum1;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(588, 76);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(97, 28);
            this.lblLogOut.TabIndex = 16;
            this.lblLogOut.Text = "Log out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // MoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 836);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblGoToProfile);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.dtpTimer);
            this.Controls.Add(this.btnMusicPause);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.rtbMoodInformation);
            this.Controls.Add(this.rbMood4);
            this.Controls.Add(this.rbMood3);
            this.Controls.Add(this.rbMood2);
            this.Controls.Add(this.rbMood1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoodsForm";
            this.Text = "MoodsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbMood1;
        private System.Windows.Forms.RadioButton rbMood2;
        private System.Windows.Forms.RadioButton rbMood3;
        private System.Windows.Forms.RadioButton rbMood4;
        private System.Windows.Forms.RichTextBox rtbMoodInformation;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.Button btnMusicPause;
        private System.Windows.Forms.DateTimePicker dtpTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private AudioSpectrumAdvance.Spectrum spectrum1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblGoToProfile;
        private System.Windows.Forms.Label lblLogOut;
    }
}