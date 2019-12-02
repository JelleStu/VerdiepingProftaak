using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BinauralBeats.Properties;

/// <summary>
/// Manoah class
/// </summary>
namespace BinauralBeats
{
    public partial class MoodsForm : Form
    {
        SoundPlayer[] Music = new SoundPlayer[5];
        public MoodsForm()
        {
            InitializeComponent();
            //Muziek toevoegen
            Music[0] = new SoundPlayer();
            Music[1] = new SoundPlayer(Resources.DeltaWave);
            Music[2] = new SoundPlayer(Resources.ThetaWave);
            Music[3] = new SoundPlayer(Resources.AlphaWave);
            Music[4] = new SoundPlayer(Resources.BetaWave);
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
        }
        int chosenmood = 0;
        string tijduur;
        string tijdminuut;
        string tijdseconde;
        private double c1;
        private double c2;

        //Alle objecten aanmaken
        Moods Delta = new Moods(1, "Helend", "0-4 Hertz", "Helend licht");
        Moods Thèta = new Moods(2, "Meditatie, diepe ontspanning, creativiteit, trance", "4-8 Hertz", "Ontspannend licht");
        Moods Alfa = new Moods(3, "Stress verlagend, beter leren", "8-14 Hertz", "Stress verlagend licht");
        Moods Bèta = new Moods(4, "Focus, energie, helder", "14-30 Hertz", "Helder licht licht");

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        private void rbMood1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood1.Checked)
            {

                string informatie = Delta.returninfo();
                chosenmood = Delta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood2.Checked)
            {
                string informatie = Thèta.returninfo();
                chosenmood = Thèta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood3.Checked)
            {
                string informatie = Alfa.returninfo();
                chosenmood = Alfa.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood4.Checked)
            {
                string informatie = Bèta.returninfo();
                chosenmood = Bèta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void playSoundFromResource(object sender, EventArgs e)
        {
            if (chosenmood != 0)
            {
                Music[chosenmood].Play();
            }
        }

        private void btnPlayMusic_Click_1(object sender, EventArgs e)
        {
            MusicTimer();
            timer2.Start();
            playSoundFromResource(sender, e);
        }

        private void btnMusicPause_Click(object sender, EventArgs e)
        {
            PauseMusic();
            chart1.Dispose();
        }
        public void PauseMusic()
        {
            Music[chosenmood].Stop();
            timer1.Stop();
            timer2.Stop();
        }
        public void MusicTimer()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tijduur = dtpTimer.Value.ToString("HH");
            tijdminuut = dtpTimer.Value.ToString("mm");
            tijdseconde = dtpTimer.Value.ToString("ss");
            int itijdseconde = Convert.ToInt32(tijdseconde);
            int itijdminuut = Convert.ToInt32(tijdminuut);
            int itijduur = Convert.ToInt32(tijduur);
            if (itijdseconde == 0)
            {
                if (itijdminuut == 0)
                {
                    if (itijduur == 0)
                    {
                        PauseMusic();
                        timer1.Stop();
                    }
                    else
                    {
                        itijduur -= 1;
                        itijdminuut = 59;
                        itijdseconde = 59;
                    }
                }
                else
                {
                    itijdminuut -= 1;
                    itijdseconde = 59;
                }
            }
            else
            {
                itijdseconde -= 1;
            }

            dtpTimer.Value= new DateTime(2019,11,28, itijduur, itijdminuut, itijdseconde );



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(c1, 3 * Math.Sin(4 * c1));// + 5 * Math.Cos(3 * x));

            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = c1;

            c1 += 0.1;

            chart2.Series[0].Points.AddXY(c2, 3 * Math.Sin(4 * c2));// + 5 * Math.Cos(3 * x));

            if (chart2.Series[0].Points.Count > 100)
                chart2.Series[0].Points.RemoveAt(0);

            chart2.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart2.ChartAreas[0].AxisX.Maximum = c2;

            c2 += 0.1;
        }
    }
}
