using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{
    public class Persons
    {
        private List<Person> personenList = new List<Person>();

        public Persons()
        {
            personenList.Add(new Person("jelle", "test"));
        }

        public void AddPerson(string username, string password)
        {
            personenList.Add(new Person(username, password));
        }

        public bool FindForPerson(string username, string password)
        {
            foreach (Person P in personenList)
            {
                if (P.GetName() == username)
                {
                    return P.GetPassword(username, password);
                }
            }
            return false;
        }

        public Person FindPerson(string username)
        {
            foreach (Person P in personenList)
            {
                if (P.GetName() == username)
                {
                    return P;
                }
            }
            return null;
        }

        public string GetData(Person currentPerson)
        {
            foreach (Person p in personenList)
            {
                if (p == currentPerson)
                {
                    return currentPerson.GetDataUser();
                }
            }

            return null;
        }

        public void SetNewPassword(Person currentPerson, string password)
        {
            foreach (Person p in personenList)
            {
                if (p == currentPerson)
                {
                    currentPerson.SetNewPassword(password);
                }
            }
        }

        int CheckPremium(string _personname)
        {
            Person currentPerson = FindPerson(_personname);
           return currentPerson.GetPremium();
        }
    }
}
