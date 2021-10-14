using FluentAssertions;
using TestDoubleSample.Test.Testdoubles;
using Xunit;

namespace TestDoubleSample.Test
{
    public class EmployeeServiceTest_HandMade
    {
        [Fact]
        public void save_employee_on_registration()
        {
            var mockRepository = new HandMockEmployeeRepository();

            var service = new EmployeeService(mockRepository);

            var expected = new Employee { FirstName = "John", LastName = "Doe" };

            service.RegisterEmployee("John", "Doe");

            mockRepository.GetCalled(nameof(IEmployeeRepository.Create))
                .CalledTimes.Should().Be(1);

            mockRepository.GetCalled(nameof(IEmployeeRepository.Create))
                .PassedArgument.Should().BeEquivalentTo(expectation: expected);
        }
    }
}
