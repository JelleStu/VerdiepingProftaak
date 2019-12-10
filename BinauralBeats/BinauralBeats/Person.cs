using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{

    public class Person
    {
        private string username;
        private string password;
        private string HiddenPassword;

        public Person(string UserName, string PassWord)
        {
            password = PassWord;
            username = UserName;
        }

        public string GetDataUser()
        {
            for (int i = 0; i < this.password.Length; i++)
            {
                HiddenPassword += "*";
            }
            return "Username: " + this.username + " Password: " + HiddenPassword;
        }

        public string GetName()
        {
            return this.username;
        }

        public bool GetPassword(string usernameFilled, string passwordFilled)
        {
            return usernameFilled == username && passwordFilled == password;
        }
    }
}
