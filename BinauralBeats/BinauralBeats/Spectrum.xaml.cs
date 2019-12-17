using System.Collections.Generic;
using System.Windows.Controls;

namespace AudioSpectrumAdvance
{
    public partial class Spectrum : UserControl
    {
        public Spectrum()
        {
            InitializeComponent();
        }       
        public void Set(List<byte> data)
        {
            if (data.Count < 23) return;

            Bar01.Value = data[0];
            Bar02.Value = data[1];
           Bar03.Value = data[2];
            Bar04.Value = data[3];
            Bar05.Value = data[4];
            Bar06.Value = data[5];
            Bar07.Value = data[6];
            Bar08.Value = data[7];
            Bar09.Value = data[8];
            Bar10.Value = data[9];
            Bar11.Value = data[10];
            Bar12.Value = data[11];
            Bar13.Value = data[12];
            Bar14.Value = data[13];
            Bar15.Value = data[14];
            Bar16.Value = data[15];
            Bar17.Value = data[16];
            Bar18.Value = data[17];
            Bar19.Value = data[18];
            Bar20.Value = data[19];
            Bar21.Value = data[20];
            Bar22.Value = data[21];
            Bar23.Value = data[22];
        }
    }
}
