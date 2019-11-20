using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{
    class Person
    {
        private string userName;
        private string password;

        public Person(string UserName, string PassWord)
        {
            this.userName = UserName;
            this.password = PassWord;
        }

        public (string userName, string password) getAccountDetails()
        {
            return (userName, password);
            
        }
    }
}
