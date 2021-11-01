using FluentAssertions;
using UserManagement;
using Xunit;

namespace UserManagmenet.Test
{
    public class UserServiceTest_SelfShunt : IUserRepository
    {
        private User _savedUser;
        private int _numberCalls;

        public void Save(User user)
        {
            _savedUser = user;
            _numberCalls++;
        }

        [Fact]
        public void save_user_on_registration()
        {
            var service = new UserService(this);
            service.Register(new RegisterUserCommand
            {
                UserName = "admin",
                Password = "123456",
            });

            _numberCalls.Should().Be(1);
            _savedUser.UserName.Should().Be("admin");
            _savedUser.Password.Should().Be("password");
        }
    }
}
