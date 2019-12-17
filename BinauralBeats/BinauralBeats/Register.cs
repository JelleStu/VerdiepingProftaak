using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinauralBeats
{
    public partial class Register : Form
    {
        private App app;

        public Register()
        {
            InitializeComponent();

        }

        public void SetApp(App _app)
        {
            app = _app;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txbUsername.Text == "" || txbPassword.Text == "")
                {
                    MessageBox.Show("Username or password cannot be empty");
                }
                else
                {
                    app.AddPerson(txbUsername.Text, txbPassword.Text);
                    MessageBox.Show(txbUsername.Text + @" is registered. You can login now.");
                    this.Hide();
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
           
        }
    }
}
