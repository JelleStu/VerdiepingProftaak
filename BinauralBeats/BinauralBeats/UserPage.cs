using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BinauralBeats.Properties;

namespace BinauralBeats
{
    public partial class UserPage : Form
    {
        private App app;
        private string currentuser;
        private string VerficationCode;
        private Person currentPerson;


        Image txImage = Image.FromFile(@"C:\Users\Jelle\Downloads\ezgif.com-gif-maker.gif");

       
        public UserPage()
        {
            InitializeComponent();
            btnCheck.Enabled = false;
            btnCheck.Visible = false;
            btnSetPassword.Enabled = false;
            btnSetPassword.Visible = false;
        }

        public void SetApp(App _app)
        {
            app = _app;
        }

        private void test_Click(object sender, EventArgs e)
        {
            MakeVerification();
            btnMakeCode.Enabled = false;
            btnMakeCode.Visible = false;
            btnCheck.Enabled = true;
            btnCheck.Visible = true;
        }

        public void SetCurrentUser(string username)
        {
            currentuser = username;
            currentPerson = app.FindPerson(currentuser);
            getData();
        }

        private void getData()
        {
            textBox1.Text = app.GetData(currentPerson);
        }

        private void MakeVerification()
        {
            VerficationCode = string.Empty;
            for (int i = 0; i < 4; i++) VerficationCode += RandomNumber();

            MessageBox.Show(VerficationCode);
        }

        private string RandomNumber()
        {
            Thread.Sleep(200);
            var random = new Random();
            return random.Next(0, 10).ToString();
        }

        private void CheckVerfication()
        {
            if (txbPassword.Text == VerficationCode)
            {
                txbPassword.Text = string.Empty;
            }
            else
            {
                txbPassword.Text = string.Empty;
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckVerfication();
            btnCheck.Enabled = false;
            btnCheck.Visible = false;
            btnSetPassword.Enabled = true;
            btnSetPassword.Visible = true;

        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text != "")
            {
                app.SetNewPassword(currentPerson, txbPassword.Text);
                getData();
                txbPassword.Text = String.Empty;
                btnSetPassword.Enabled = false;
                btnSetPassword.Visible = false;
                btnMakeCode.Enabled = true;
                btnMakeCode.Visible = true;
            }
            else
            {
                MessageBox.Show(@"Password can't be blank");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           pictureBox1.Image = Image.FromFile(@"C:\Users\Jelle\Downloads\ezgif.com-gif-maker.gif");
           Thread.Sleep(500);
           pictureBox1.Image = Image.FromFile(@"C:\Users\Jelle\Downloads\premium_onn.gif");

        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = txImage;
        }
    }
}