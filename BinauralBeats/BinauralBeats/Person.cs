using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{
    class Person
    {
        private static string username;
        private static string password;

        public Person(string UserName, string PassWord)
        {
            password = PassWord;
            username = UserName;
        }

        public static void TestFunction()
        {
            Console.Write("test");
        }
        public static bool GetPassword(string usernameFilled, string passwordFilled)
        {
            return usernameFilled == username && passwordFilled == password;
        }
    }
}
