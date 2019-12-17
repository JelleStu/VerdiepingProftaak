using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Verdiepende_proftaak
{
    class Advertisements
    {
        private enum ads { PhilipsHue=0, Intersport=1 }
        List<Image> pboximage = new List<Image>();
        List<string> weburl = new List<string>();
        public Image pbox;
        Random randomad = new Random();
        private int adnumber { get; set; }
        private string Sweburl { get; set; }

        public Advertisements()
        {
            pboximage.Add(Properties.Resources.PhilipsHue);
            weburl.Add("https://www.philips.com/");
            pboximage.Add(Properties.Resources.Intersport);
            weburl.Add("https://www.intersport.nl/");

            Advertisement();
        }
        public Advertisements(string adClicked)
        {
            AdvertisementClicked();
        }
        private int CalculateAd()
        {
            Array values = Enum.GetValues(typeof(ads));
            ads rads = (ads)values.GetValue(randomad.Next(values.Length));
            return (int)rads;
        }
        private void Advertisement()
        {
            adnumber = CalculateAd();
            pbox = pboximage[adnumber];
            Sweburl = weburl[adnumber]; 
        }
        public void AdvertisementClicked()
        {
            System.Diagnostics.Process.Start(Sweburl);
            MessageBox.Show("Advertentie "+ adnumber +" is geklikt");
        }
    }
}
