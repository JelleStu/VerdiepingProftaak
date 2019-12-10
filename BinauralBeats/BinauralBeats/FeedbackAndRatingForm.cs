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
        StarsForRating star = new StarsForRating();
        public FeedbackAndRatingForm()
        {
            InitializeComponent();
        }

        int score;
        string feedback;

        private void pbStar1_Click(object sender, EventArgs e)
        {
            score = 1;
            star.CalculateStars(score);
            StarsImages();
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            score = 2;
            star.CalculateStars(score);
            StarsImages();
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            score = 3;
            star.CalculateStars(score);
            StarsImages();
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            score = 4;
            star.CalculateStars(score);
            StarsImages();
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            score = 5;
            star.CalculateStars(score);
            StarsImages();
        }
        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            feedback = tbFeedback.Text;
            FeedbackAndRating rating = new FeedbackAndRating(score, feedback);
        }
        public void StarsImages()
        {
            pbStar1.Image = star.pbox[0];
            pbStar2.Image = star.pbox[1];
            pbStar3.Image = star.pbox[2];
            pbStar4.Image = star.pbox[3];
            pbStar5.Image = star.pbox[4];
        }
    }
}
