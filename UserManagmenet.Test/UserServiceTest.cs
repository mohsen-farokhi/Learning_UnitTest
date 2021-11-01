using FluentAssertions;
using System;
using UserManagement;
using UserManagmenet.Test.TestDoubles;
using Xunit;

namespace UserManagmenet.Test
{
    public class UserServiceTest
    {
        [Fact]
        public void save_user_on_registration()
        {
            var repository = new UserRepositorySpy();

            var service = new UserService(repository);

            service.Register(new RegisterUserCommand
            {
                UserName = "admin",
                Password = "123456",
            });

            repository.GetNumberOfSavedUsers().Should().Be(1);
            repository.GetSavedUser().UserName.Should().Be("admin");
            repository.GetSavedUser().Password.Should().Be("password");
        }
    }
}
