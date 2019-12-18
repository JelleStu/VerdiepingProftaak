using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinauralBeats
{
    class FeedbackAndRating
    {
        int score { get; }
        string feedback { get; }
        public FeedbackAndRating()
        {
            score = 0;
            feedback = string.Empty;
            CheckFeedback();
        }
        public FeedbackAndRating(int _score, string _feedback)
        {
            score = _score;
            feedback = _feedback;
            CheckFeedback();
        }
        private void CheckFeedback()
        {
            if (score == 0)
            {
                MessageBox.Show("Enter a score");
            }
            else
            {
                //Database connectie
                MessageBox.Show("Thank you for rating our app!");
                FeedbackAndRatingForm.ActiveForm.Close();
            }
        }
    }
}
