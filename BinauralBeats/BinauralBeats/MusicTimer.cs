using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{
    class MusicTimer
    {
        public int tijduur { get; set; }
        public int tijdminuut { get; set; }
        public int tijdseconde { get; set; }
        //public MusicTimer()
        //{
        //    tijduur=0;
        //    tijdminuut = 0;
        //    tijdseconde = 0;
        //    BerekenTijd(tijduur, tijdminuut, tijdseconde);
        //}
        public MusicTimer(string _tijduur, string _tijdminuut, string _tijdseconde)
        {
            tijduur = Convert.ToInt32(_tijduur);
            tijdminuut = Convert.ToInt32(_tijdminuut);
            tijdseconde = Convert.ToInt32(_tijdseconde);
            BerekenTijd();
        }

        public void BerekenTijd()
        {
            if (tijdseconde == 0)
            {
                if (tijdminuut == 0)
                {
                    if (tijduur == 0)
                    {
                        tijduur = 0;
                        tijdminuut = 0;
                        tijdseconde = 0;
                    }
                    else
                    {
                        tijduur -= 1;
                        tijdminuut = 59;
                        tijdseconde = 59;
                    }
                }
                else
                {
                    tijduur=tijduur;
                    tijdminuut -= 1;
                    tijdseconde = 59; 
                }
            }
            else
            {
                tijdseconde -= 1;
                tijdminuut=tijdminuut;
                tijduur=tijduur;
            }
        }
    }
}
