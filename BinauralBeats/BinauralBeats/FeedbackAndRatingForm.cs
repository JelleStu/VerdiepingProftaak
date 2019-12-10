using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verdiepende_proftaak
{
    public partial class FeedbackAndRatingForm : Form
    {
        public FeedbackAndRatingForm()
        {
            InitializeComponent();
            pbStar1.Image = Properties.Resources.StarEmpty;
            pbStar2.Image = Properties.Resources.StarEmpty;
            pbStar3.Image = Properties.Resources.StarEmpty;
            pbStar4.Image = Properties.Resources.StarEmpty;
            pbStar5.Image = Properties.Resources.StarEmpty;
        }
        int score;
        string feedback;

        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.StarFull;
            pbStar2.Image = Properties.Resources.StarEmpty;
            pbStar3.Image = Properties.Resources.StarEmpty;
            pbStar4.Image = Properties.Resources.StarEmpty;
            pbStar5.Image = Properties.Resources.StarEmpty;
            score = 1;
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.StarFull;
            pbStar2.Image = Properties.Resources.StarFull;
            pbStar3.Image = Properties.Resources.StarEmpty;
            pbStar4.Image = Properties.Resources.StarEmpty;
            pbStar5.Image = Properties.Resources.StarEmpty;
            score = 2;
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.StarFull;
            pbStar2.Image = Properties.Resources.StarFull;
            pbStar3.Image = Properties.Resources.StarFull;
            pbStar4.Image = Properties.Resources.StarEmpty;
            pbStar5.Image = Properties.Resources.StarEmpty;
            score = 3;
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.StarFull;
            pbStar2.Image = Properties.Resources.StarFull;
            pbStar3.Image = Properties.Resources.StarFull;
            pbStar4.Image = Properties.Resources.StarFull;
            pbStar5.Image = Properties.Resources.StarEmpty;
            score = 4;
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Properties.Resources.StarFull;
            pbStar2.Image = Properties.Resources.StarFull;
            pbStar3.Image = Properties.Resources.StarFull;
            pbStar4.Image = Properties.Resources.StarFull;
            pbStar5.Image = Properties.Resources.StarFull;
            score = 5;
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            feedback = tbFeedback.Text;
            FeedbackAndRating rating = new FeedbackAndRating(score, feedback);
        }
    }
}
