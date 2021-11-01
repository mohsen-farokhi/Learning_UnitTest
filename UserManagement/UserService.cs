using System;

namespace UserManagement
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(RegisterUserCommand command)
        {
            var user = new User(command.UserName, command.Password);
            _userRepository.Save(user);
        }
    }

}
