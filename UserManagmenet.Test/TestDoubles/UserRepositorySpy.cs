using UserManagement;

namespace UserManagmenet.Test.TestDoubles
{
    internal class UserRepositorySpy : IUserRepository
    {
        private User _user;
        private int _callNumbers;

        public void Save(User user)
        {
            _user = user;
            _callNumbers ++;
        }

        public User GetSavedUser()
        {
            return _user;
        }

        public int GetNumberOfSavedUsers()
        {
            return _callNumbers;
        }
    }
}
