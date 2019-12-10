using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verdiepende_proftaak
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
        public void CheckFeedback()
        {
            if (score == 0)
            {
                MessageBox.Show("Enter a score");
            }
            else
            {
                //Database connectie
                MessageBox.Show("Bedankt voor het beoordelen van deze app!");
                FeedbackAndRatingForm.ActiveForm.Close();
            }
        }
    }
}
