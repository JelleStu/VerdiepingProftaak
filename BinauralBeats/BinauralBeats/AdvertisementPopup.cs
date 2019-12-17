using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Verdiepende_proftaak
{
    public partial class AdvertisementPopup : Form
    {

        Advertisements ad = new Advertisements();
        public AdvertisementPopup()
        {
            InitializeComponent();
        }

        private void AdvertisementPopup_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ad.pbox;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ad.AdvertisementClicked();
        }
    }
}
