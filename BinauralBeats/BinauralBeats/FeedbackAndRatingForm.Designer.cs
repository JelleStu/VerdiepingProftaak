namespace Verdiepende_proftaak
{
    partial class FeedbackAndRatingForm
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
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::Verdiepende_proftaak.Properties.Resources.StarEmpty;
            this.pbStar1.Location = new System.Drawing.Point(56, 55);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(144, 135);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar1.TabIndex = 0;
            this.pbStar1.TabStop = false;
            this.pbStar1.Click += new System.EventHandler(this.pbStar1_Click);
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::Verdiepende_proftaak.Properties.Resources.StarEmpty;
            this.pbStar2.Location = new System.Drawing.Point(206, 55);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(144, 135);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar2.TabIndex = 1;
            this.pbStar2.TabStop = false;
            this.pbStar2.Click += new System.EventHandler(this.pbStar2_Click);
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::Verdiepende_proftaak.Properties.Resources.StarEmpty;
            this.pbStar3.Location = new System.Drawing.Point(356, 55);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(144, 135);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar3.TabIndex = 2;
            this.pbStar3.TabStop = false;
            this.pbStar3.Click += new System.EventHandler(this.pbStar3_Click);
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::Verdiepende_proftaak.Properties.Resources.StarEmpty;
            this.pbStar4.Location = new System.Drawing.Point(506, 55);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(144, 135);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar4.TabIndex = 3;
            this.pbStar4.TabStop = false;
            this.pbStar4.Click += new System.EventHandler(this.pbStar4_Click);
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::Verdiepende_proftaak.Properties.Resources.StarEmpty;
            this.pbStar5.Location = new System.Drawing.Point(656, 55);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(144, 135);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar5.TabIndex = 4;
            this.pbStar5.TabStop = false;
            this.pbStar5.Click += new System.EventHandler(this.pbStar5_Click);
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(56, 277);
            this.tbFeedback.Multiline = true;
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(744, 149);
            this.tbFeedback.TabIndex = 5;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Location = new System.Drawing.Point(276, 447);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(277, 92);
            this.btnSendFeedback.TabIndex = 6;
            this.btnSendFeedback.Text = "button1";
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // FeedbackAndRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(870, 551);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.tbFeedback);
            this.Controls.Add(this.pbStar5);
            this.Controls.Add(this.pbStar4);
            this.Controls.Add(this.pbStar3);
            this.Controls.Add(this.pbStar2);
            this.Controls.Add(this.pbStar1);
            this.Name = "FeedbackAndRatingForm";
            this.Text = "FeedbackAndRatingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
    }
}