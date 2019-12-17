using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Un4seen.Bass;

namespace BinauralBeats
{
    public partial class LogIn : Form
    {
        private bool First;
        private readonly App app;
        private string CurrentUser;
        private LogIn form;
        private Bass bass;

        public LogIn()
        {
            InitializeComponent();
            app = new App();
            form = this;
            First = app.GetInit();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool PasswordOk = app.FindForPerson(txbUsername.Text, txbPassword.Text);
                if (PasswordOk != true)
                {
                    MessageBox.Show(@"Gebruikersnaam of wachtwoord onjuist");
                }
                else
                {
                    CurrentUser = txbUsername.Text;
                    SetForm();
                    if (First == false)
                    {
                        MoodsForm moodfrom = new MoodsForm();
                        app.SetMoodsForm(moodfrom);
                        moodfrom.SetCurrentUser(CurrentUser);
                        moodfrom.SetApp(app);
                        moodfrom.Show();
                    }
                    else
                    {
                        app.SetMoodsFormActive();
                    }
                    txbPassword.Text = string.Empty;
                    txbUsername.Text = string.Empty;
                    Hide();
                }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.SetApp(app);
            registerForm.Show();
        }

        private void SetForm()
        {
            app.SetLoginFom(form);
        }

        public void SetBass(Bass _bass)
        {
            bass = _bass;
        }

        
    }
}