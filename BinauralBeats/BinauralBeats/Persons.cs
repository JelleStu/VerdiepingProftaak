using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinauralBeats
{
    class Persons
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
    }
}
