using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Verdiepende_proftaak
{
    class StarsForRating
    {
        public Image[] pboximage = new Image[2];
        public Image[] pbox = new Image[6];
        public StarsForRating()
        {
            pboximage[0] = Properties.Resources.StarEmpty;
            pboximage[1] = Properties.Resources.StarFull;
        }
        public void CalculateStars(int score)
        {
            for (int start = 0; start <= score; start++)
            {
                pbox[start] = pboximage[1];
            }
            for (int start = 5; start >= score; start--)
            {
                pbox[start] = pboximage[0];
            }
        }
    }
}
