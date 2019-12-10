using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BinauralBeats
{
    public partial class UserPage : Form
    {
        private string currentuser;
        private App app;
        public UserPage()
        {
            InitializeComponent();
        }

        public void SetApp(App _app)
        {
            app = _app;
        }
        private void test_Click(object sender, EventArgs e)
        {
            getData();
        }
        public void SetCurrentUser(string username)
        {
            currentuser = username;
        }

        void getData()
        { 
            Person currentPerson = app.FindPerson(currentuser);
            textBox1.Text = app.GetData(currentPerson);
        }
    }
}
