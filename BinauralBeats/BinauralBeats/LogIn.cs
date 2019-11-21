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
        public LogIn()
        {
            InitializeComponent();
            Person.AddPerson("Jelle", "123");
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {   
            bool AccountOk = Person.GetPassword(txbUsername.Text, txbPassword.Text);
            if (AccountOk != true) return;
            MoodsForm moodfrom = new MoodsForm();
            moodfrom.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}
