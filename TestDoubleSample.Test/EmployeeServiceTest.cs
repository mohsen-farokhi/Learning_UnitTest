using FluentAssertions;
using Moq;
using Xunit;

namespace TestDoubleSample.Test
{
    public class EmployeeServiceTest
    {
        [Fact]
        public void save_employee_on_registration()
        {
            var mockRepository = new Mock<IEmployeeRepository>();

            var service = new EmployeeService(mockRepository.Object);

            var expected = new Employee { FirstName = "John", LastName = "Doe" };

            service.RegisterEmployee("John", "Doe");

            //mockRepository.Verify(c => c.Create(It.IsAny<Employee>()), Times.Once);

            mockRepository.Verify
                (c => c.Create(It.Is<Employee>
                    (c => c.FirstName == "John" && c.LastName == "Doe")),
                Times.Once);
        }
    }
}
