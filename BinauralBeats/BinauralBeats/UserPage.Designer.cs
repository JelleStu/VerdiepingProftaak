namespace BinauralBeats
{
    partial class UserPage
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
            this.btnMakeCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeCode
            // 
            this.btnMakeCode.Location = new System.Drawing.Point(117, 236);
            this.btnMakeCode.Name = "btnMakeCode";
            this.btnMakeCode.Size = new System.Drawing.Size(136, 36);
            this.btnMakeCode.TabIndex = 0;
            this.btnMakeCode.Text = "Change password";
            this.btnMakeCode.UseVisualStyleBackColor = true;
            this.btnMakeCode.Click += new System.EventHandler(this.test_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 153);
            this.textBox1.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(117, 292);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(136, 22);
            this.txbPassword.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(117, 236);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(136, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CheckCode";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Enabled = false;
            this.btnSetPassword.Location = new System.Drawing.Point(117, 236);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(136, 36);
            this.btnSetPassword.TabIndex = 4;
            this.btnSetPassword.Text = "Set password";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 390);
            this.Controls.Add(this.btnSetPassword);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMakeCode);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSetPassword;
    }
}