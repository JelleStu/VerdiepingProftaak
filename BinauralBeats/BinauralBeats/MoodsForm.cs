using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
/// <summary>
/// Manoah class
/// </summary>
namespace BinauralBeats
{
    public partial class MoodsForm : Form
    {
        string[] Music = new string[5];
        public MoodsForm()
        {
            InitializeComponent();
            //Muziek toevoegen
            Music[0] = " ";
            Music[1] = "C:/Users/Manoah Somers/Documents/Fontys/2019-2020/Proftaak/Verdieping proftaak/VerdiepingProftaak/BinauralBeats/BinauralBeats/Resources/Binaural Beat - Delta Wave Frequency 90minute 100 Pure.mp3";
            Music[2] = "C:/Users/Manoah Somers/Documents/Fontys/2019-2020/Proftaak/Verdieping proftaak/VerdiepingProftaak/BinauralBeats/BinauralBeats/Resources/Binaural Beat - Theta Wave 100 Pure Theta Frequency.mp3";
            Music[3] = "C:/Users/Manoah Somers/Documents/Fontys/2019-2020/Proftaak/Verdieping proftaak/VerdiepingProftaak/BinauralBeats/BinauralBeats/Resources/Binaural Beat - Alpha Wave Frequency 90minute 100 Pure.mp3";
            Music[4] = "C:/Users/Manoah Somers/Documents/Fontys/2019-2020/Proftaak/Verdieping proftaak/VerdiepingProftaak/BinauralBeats/BinauralBeats/Resources/Binaural Beat - Beta Wave Frequency 100 Pure Beta.mp3";
        }
        int chosenmood = 0;
        decimal tijd;
        string tijduur;
        string tijdminuut;
        string tijdseconde;

        //Alle objecten aanmaken
        Moods Delta = new Moods(1, "Helend", "0-4 Hertz", "Helend licht");
        Moods Thèta = new Moods(2, "Meditatie, diepe ontspanning, creativiteit, trance", "4-8 Hertz", "Ontspannend licht");
        Moods Alfa = new Moods(3, "Stress verlagend, beter leren", "8-14 Hertz", "Stress verlagend licht");
        Moods Bèta = new Moods(4, "Focus, energie, helder", "14-30 Hertz", "Helder licht licht");


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
                //wplayer.URL = Music[chosenmood];
                //wplayer.controls.play();
            }
        }

        private void btnPlayMusic_Click_1(object sender, EventArgs e)
        {
            MusicTimer();
            playSoundFromResource(sender, e);
        }

        private void btnMusicPause_Click(object sender, EventArgs e)
        {
            PauseMusic();
        }
        public void PauseMusic()
        {
            timer1.Stop();
            //wplayer.controls.pause();
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
                        tijduur = Convert.ToString(itijduur -= 1);
                        tijdminuut = Convert.ToString(itijdminuut = 59);
                        tijdseconde = Convert.ToString(itijdseconde = 59);
                    }
                }
                else
                {
                    tijdminuut = Convert.ToString(itijdminuut -= 1);
                    tijdseconde = Convert.ToString(itijdseconde = 59);
                }
            }
            else
            {
                tijdseconde = Convert.ToString(itijdseconde -= 1);
            }
            int iitijdseconde = Convert.ToInt32(tijdseconde);
            int iitijdminuut = Convert.ToInt32(tijdminuut);
            int iitijduur = Convert.ToInt32(tijduur);

            dtpTimer.Value= new DateTime(2019,11,28, iitijduur, iitijdminuut, iitijdseconde );

        }
    }
}
