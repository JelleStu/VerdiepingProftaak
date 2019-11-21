using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Manoah class
/// </summary>
namespace BinauralBeats
{
    public partial class MoodsForm : Form
    {
        public MoodsForm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        int i = 0;
        

        private void rbMood1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood1.Checked)
            {
                Moods DiepeSlaap = new Moods(1, "Helend", "0-4 Hertz", "Helend licht");
                string informatie = DiepeSlaap.returninfo();
                label1.Text = informatie;
            }
        }

        private void rbMood2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood2.Checked)
            {
                Moods Thèta = new Moods(2, "Meditatie, diepe ontspanning, creativiteit, trance", "4-8 Hertz", "Ontspannend licht");
                string informatie = Thèta.returninfo();
                label1.Text = informatie;
            }
        }

        private void rbMood3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood3.Checked)
            {
                Moods Alfa = new Moods(3, "tress verlagend, beter leren", "8-14 Hertz", "Stress verlagend licht");
                string informatie = Alfa.returninfo();
                label1.Text = informatie;
            }
        }

        private void rbMood4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood4.Checked)
            {
                Moods Bèta = new Moods(4, "Focus, energie, helder", "14-30 Hertz", "Helder licht licht");
                string informatie = Bèta.returninfo();
                label1.Text = informatie;
            }
=======

        private void MoodsForm_Load(object sender, EventArgs e)
        {

>>>>>>> develop
        }
    }
}
