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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoodsForm));
            this.rbMood1 = new System.Windows.Forms.RadioButton();
            this.rbMood2 = new System.Windows.Forms.RadioButton();
            this.rbMood3 = new System.Windows.Forms.RadioButton();
            this.rbMood4 = new System.Windows.Forms.RadioButton();
            this.rtbMoodInformation = new System.Windows.Forms.RichTextBox();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnMusicPause = new System.Windows.Forms.Button();
            this.dtpTimer = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMood1
            // 
            this.rbMood1.AutoSize = true;
            this.rbMood1.Location = new System.Drawing.Point(39, 54);
            this.rbMood1.Name = "rbMood1";
            this.rbMood1.Size = new System.Drawing.Size(146, 36);
            this.rbMood1.TabIndex = 1;
            this.rbMood1.TabStop = true;
            this.rbMood1.Text = "Mood 1";
            this.rbMood1.UseVisualStyleBackColor = true;
            this.rbMood1.CheckedChanged += new System.EventHandler(this.rbMood1_CheckedChanged);
            // 
            // rbMood2
            // 
            this.rbMood2.AutoSize = true;
            this.rbMood2.Location = new System.Drawing.Point(39, 121);
            this.rbMood2.Name = "rbMood2";
            this.rbMood2.Size = new System.Drawing.Size(146, 36);
            this.rbMood2.TabIndex = 2;
            this.rbMood2.TabStop = true;
            this.rbMood2.Text = "Mood 2";
            this.rbMood2.UseVisualStyleBackColor = true;
            this.rbMood2.CheckedChanged += new System.EventHandler(this.rbMood2_CheckedChanged);
            // 
            // rbMood3
            // 
            this.rbMood3.AutoSize = true;
            this.rbMood3.Location = new System.Drawing.Point(39, 184);
            this.rbMood3.Name = "rbMood3";
            this.rbMood3.Size = new System.Drawing.Size(146, 36);
            this.rbMood3.TabIndex = 3;
            this.rbMood3.TabStop = true;
            this.rbMood3.Text = "Mood 3";
            this.rbMood3.UseVisualStyleBackColor = true;
            this.rbMood3.CheckedChanged += new System.EventHandler(this.rbMood3_CheckedChanged);
            // 
            // rbMood4
            // 
            this.rbMood4.AutoSize = true;
            this.rbMood4.Location = new System.Drawing.Point(39, 250);
            this.rbMood4.Name = "rbMood4";
            this.rbMood4.Size = new System.Drawing.Size(146, 36);
            this.rbMood4.TabIndex = 4;
            this.rbMood4.TabStop = true;
            this.rbMood4.Text = "Mood 4";
            this.rbMood4.UseVisualStyleBackColor = true;
            this.rbMood4.CheckedChanged += new System.EventHandler(this.rbMood4_CheckedChanged);
            // 
            // rtbMoodInformation
            // 
            this.rtbMoodInformation.Location = new System.Drawing.Point(690, 533);
            this.rtbMoodInformation.Name = "rtbMoodInformation";
            this.rtbMoodInformation.Size = new System.Drawing.Size(100, 96);
            this.rtbMoodInformation.TabIndex = 6;
            this.rtbMoodInformation.Text = "";
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(463, 74);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(161, 131);
            this.btnPlayMusic.TabIndex = 7;
            this.btnPlayMusic.Text = "button1";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            // 
            // btnMusicPause
            // 
            this.btnMusicPause.Location = new System.Drawing.Point(823, 156);
            this.btnMusicPause.Name = "btnMusicPause";
            this.btnMusicPause.Size = new System.Drawing.Size(178, 106);
            this.btnMusicPause.TabIndex = 8;
            this.btnMusicPause.Text = "button1";
            this.btnMusicPause.UseVisualStyleBackColor = true;
            // 
            // dtpTimer
            // 
            this.dtpTimer.Location = new System.Drawing.Point(831, 164);
            this.dtpTimer.Name = "dtpTimer";
            this.dtpTimer.Size = new System.Drawing.Size(200, 38);
            this.dtpTimer.TabIndex = 9;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(717, 103);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(97, 102);
            this.axWindowsMediaPlayer2.TabIndex = 12;
            // 
            // MoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 887);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.dtpTimer);
            this.Controls.Add(this.btnMusicPause);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.rtbMoodInformation);
            this.Controls.Add(this.rbMood4);
            this.Controls.Add(this.rbMood3);
            this.Controls.Add(this.rbMood2);
            this.Controls.Add(this.rbMood1);
            this.Name = "MoodsForm";
            this.Text = "MoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}