using System.Windows.Forms;

namespace BinauralBeats
{
    public class App
    {
        private bool Init;
        private string CurrentUser;
        private readonly Persons personenListApPersons;
        private LogIn loginform;
        private MoodsForm moodfrom;
        public App()
        {
            personenListApPersons = new Persons();
            CurrentUser = string.Empty;
        }

        public void AddPerson(string username, string password)
        {
            personenListApPersons.AddPerson(username, password);
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

        public void SetNewPassword(Person currentPerson, string password)
        {
            personenListApPersons.SetNewPassword(currentPerson, password);
        }

        public void SetLoginActive() {
            loginform.Show();
        }

        public void SetLoginFom(LogIn form)
        {
            loginform = form;
        }

        public void SetMoodsForm(MoodsForm _form)
        {
            moodfrom = _form;
        }

        public void SetMoodsFormActive()
        {
            moodfrom.Show();
        }

        public bool GetInit()
        {
            return Init;
        }

        public void SetInit()
        {
            Init = true;
        }
    }
}