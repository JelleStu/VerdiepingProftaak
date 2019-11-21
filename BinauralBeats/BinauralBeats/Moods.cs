using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinauralBeats
{
    class Moods
    {
        private static string mood = string.Empty;
        private static int chosenMood;
        public static string music { get; set; }
        public static string light { get; set; }

        public Moods(int selectedMood, string _mood, string _music, string _light)
        {
            mood = _mood;
            chosenMood = selectedMood;
            music = _music;
            light = _light;
        }
        private string moodinformatie = "De gevoels informatie is: " + mood + music + light;

        public string returninfo()
        {
            return moodinformatie;
        }
    }
}
