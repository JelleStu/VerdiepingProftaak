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
<<<<<<< HEAD
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rbMood1 = new System.Windows.Forms.RadioButton();
            this.rbMood2 = new System.Windows.Forms.RadioButton();
            this.rbMood3 = new System.Windows.Forms.RadioButton();
            this.rbMood4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(39, 515);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(371, 114);
            this.trackBar1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // MoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 887);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMood4);
            this.Controls.Add(this.rbMood3);
            this.Controls.Add(this.rbMood2);
            this.Controls.Add(this.rbMood1);
            this.Controls.Add(this.trackBar1);
            this.Name = "MoodsForm";
            this.Text = "MoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.SuspendLayout();
            // 
            // MoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MoodsForm";
            this.Text = "MoodsForm";
            this.Load += new System.EventHandler(this.MoodsForm_Load);
            this.ResumeLayout(false);
>>>>>>> develop

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton rbMood1;
        private System.Windows.Forms.RadioButton rbMood2;
        private System.Windows.Forms.RadioButton rbMood3;
        private System.Windows.Forms.RadioButton rbMood4;
        private System.Windows.Forms.Label label1;
    }
}