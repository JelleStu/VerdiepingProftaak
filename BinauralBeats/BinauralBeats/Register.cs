﻿using System;
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
        private Persons personenList;

        public Register()
        {
            InitializeComponent();

        }

        public void SetList(Persons personsList)
        {
            personenList = personsList;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            try
            {
                personenList.AddPerson(txbUsername.Text, txbPassword.Text);
                MessageBox.Show("User is created!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
           
        }
    }
}
