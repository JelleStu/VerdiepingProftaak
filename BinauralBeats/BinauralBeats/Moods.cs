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
        private string chosenMood = string.Empty;

        //construct-er
        public Moods(string mood)
        {
            this.mood = chosenMood; 
        }

        public string returnChosenMood()
        {
            return chosenMood;
        }

    }
}
