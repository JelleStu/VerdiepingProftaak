using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{

    public class Person
    {
        public static List<Person> Persons;
        private static string username;
        private static string password;

        public Person(string UserName, string PassWord)
        {
            password = PassWord;
            username = UserName;
        }

        public static void AddPerson(string usernameRegister, string passwordRegister)
        {
            if (Persons == null)
            {
                Persons = new List<Person>();
                Person.AddPerson("Jelle", "123");
            }
            else
            {
                Persons.Add(new Person(usernameRegister, passwordRegister));
            }
        }

        public static bool GetPassword(string usernameFilled, string passwordFilled)
        {
            return usernameFilled == username && passwordFilled == password;
        }
    }
}
