using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinauralBeats
{

    public class Person
    {
        private string username;
        private string password;
        private string HiddenPassword;
        private int premium = 0; //New person has never premium
        private string premiumstring = "no";

        public Person(string UserName, string PassWord)
        {
            password = PassWord;
            username = UserName;
        }

        public string GetDataUser()
        {
            HiddenPassword = String.Empty;
            for (int i = 0; i < this.password.Length; i++)
            {
                HiddenPassword += "*";
            }

            if (premium != 0)
                premiumstring = "yes";

            return "Username: " + this.username + "\r\n Password: " + HiddenPassword + "\r\nPremium: "+ premiumstring;
        }

        public string GetName()
        {
            return this.username;
        }

        public bool GetPassword(string usernameFilled, string passwordFilled)
        {
            return usernameFilled == username && passwordFilled == password;
        }
            
        public void SetNewPassword(string _password)
        {
            password = _password;
        }

        public int GetPremium()
        {
            return this.premium;
        }
    }
}
