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

        public Person(string UserName, string PassWord)
        {
            password = PassWord;
            username = UserName;
        }

        public string GetName()
        {
            return username;
        }

        public bool GetPassword(string usernameFilled, string passwordFilled)
        {
            return usernameFilled == username && passwordFilled == password;
        }
    }
}
