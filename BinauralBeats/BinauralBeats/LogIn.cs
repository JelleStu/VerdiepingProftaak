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
        private Persons personenlist;
        public LogIn()
        {
            InitializeComponent();
            personenlist = new Persons();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool PasswordOk = personenlist.FindForPerson(txbUsername.Text, txbPassword.Text);
            if (PasswordOk != true) return;
            MoodsForm moodfrom = new MoodsForm();
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
