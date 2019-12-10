namespace BinauralBeats
{
    public class App
    {
        private string CurrentUser;
        private readonly Persons personenListApPersons;

        public App()
        {
            personenListApPersons = new Persons();
            CurrentUser = string.Empty;
        }

        public void AddPerson()
        {
            personenListApPersons.AddPerson("test", "test");
        }

        public bool FindForPerson(string username, string password)
        {
            return personenListApPersons.FindForPerson(username, password);
        }

        public Person FindPerson(string username)
        {
            return personenListApPersons.FindPerson(username);
        }

        public string GetData(Person currentPerson)
        {
            return personenListApPersons.GetData(currentPerson);
        }
    }
}