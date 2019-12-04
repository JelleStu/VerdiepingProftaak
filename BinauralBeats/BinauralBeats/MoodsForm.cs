using System;
using System.Media;
using System.Windows.Forms;
using AudioSpectrumAdvance;
using BinauralBeats.Properties;

/// <summary>
/// Manoah class
/// </summary>
namespace BinauralBeats
{
    public partial class MoodsForm : Form
    {
        private readonly Moods Alfa = new Moods(3, "Stress verlagend, beter leren", "8-14 Hertz",
            "Stress verlagend licht");

        private readonly Moods Bèta = new Moods(4, "Focus, energie, helder", "14-30 Hertz", "Helder licht licht");
        private int chosenmood;

        //Alle objecten aanmaken
        private readonly Moods Delta = new Moods(1, "Helend", "0-4 Hertz", "Helend licht");
        private readonly SoundPlayer[] Music = new SoundPlayer[5];

        private SoundPlayer player = new SoundPlayer();

        private readonly Moods Thèta = new Moods(2, "Meditatie, diepe ontspanning, creativiteit, trance", "4-8 Hertz",
            "Ontspannend licht");

        private string tijdminuut;
        private string tijdseconde;
        private string tijduur;

        public MoodsForm()
        {
            InitializeComponent();
            //Muziek toevoegen
            Music[0] = new SoundPlayer();
            Music[1] = new SoundPlayer(Resources.DeltaWave);
            Music[2] = new SoundPlayer(Resources.ThetaWave);
            Music[3] = new SoundPlayer(Resources.AlphaWave);
            Music[4] = new SoundPlayer(Resources.BetaWave);

            var analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
        }


        private void rbMood1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood1.Checked)
            {
                var informatie = Delta.returninfo();
                chosenmood = Delta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood2.Checked)
            {
                var informatie = Thèta.returninfo();
                chosenmood = Thèta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood3.Checked)
            {
                var informatie = Alfa.returninfo();
                chosenmood = Alfa.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void rbMood4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMood4.Checked)
            {
                var informatie = Bèta.returninfo();
                chosenmood = Bèta.returnChosenMood();
                rtbMoodInformation.Text = informatie;
                PauseMusic();
            }
        }

        private void playSoundFromResource(object sender, EventArgs e)
        {
            if (chosenmood != 0) Music[chosenmood].Play();
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

            MusicTimer musictimer = new MusicTimer(tijduur, tijdminuut, tijdseconde);

            dtpTimer.Value = new DateTime(2019, 11, 28, musictimer.tijduur, musictimer.tijdminuut, musictimer.tijdseconde);
        }
    }
}