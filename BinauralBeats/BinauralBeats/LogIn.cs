using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinauralBeats
{
    
    public partial class LogIn : Form
    {
        private string CurrentUser;
        private App app;
        
        public LogIn()
        {
            InitializeComponent(); 
            app = new App();
            app.AddPerson();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool PasswordOk = app.FindForPerson(txbUsername.Text, txbPassword.Text);
            if (PasswordOk != true) return;
            CurrentUser = txbUsername.Text;
            MoodsForm moodfrom = new MoodsForm();
            moodfrom.SetCurrentUser(CurrentUser);
            moodfrom.SetApp(app);
            moodfrom.Show();
            this.Hide();
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
           registerForm.Show();
        }
    }
}
