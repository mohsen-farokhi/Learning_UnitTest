using FluentAssertions;
using TestDoubleSample.Test.Testdoubles;
using Xunit;

namespace TestDoubleSample.Test
{
    public class TaxCalculatorText
    {
        [Theory]
        [InlineData(1000000, 9, 910000)]
        [InlineData(1000000, 9.5, 905000)]
        [InlineData(1000000, 0, 1000000)]
        public void Tax_is_subtracted_from_salary
            (long salary, double taxRate, double expected)
        {
            var repository = StubTaxRepository
                .CreateNewStub()
                .WhichReturnsTaxRateAs(taxRate);

            var service = new TaxService(repository);

            var salaryWithoutTaxes = service.CalculateSalary(salary);

            salaryWithoutTaxes.Should().Be(expected);
        }
    }
}
