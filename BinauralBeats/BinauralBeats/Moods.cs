using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinauralBeats
{
    class Moods
    {
        private string mood = string.Empty;
        private int chosenMood;
        private string music { get; set; }
        private string light { get; set; }
        private string moodinformatie = string.Empty;



        public Moods(int selectedMood, string _mood, string _music, string _light)
        {
            this.mood = _mood;
            this.chosenMood = selectedMood;
            this.music = _music;
            this.light = _light;
        }

        public string returninfo()
        {
            moodinformatie = ("De gevoels informatie is: " + mood + ", " + music + ", " + light);
            return moodinformatie;
        }
        public int returnChosenMood()
        {
            return chosenMood;
        }
    }
}
