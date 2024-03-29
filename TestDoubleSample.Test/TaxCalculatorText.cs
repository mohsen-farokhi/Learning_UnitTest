﻿using FluentAssertions;
using Moq;
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
            var mockRepository = new Mock<ITaxRepository>();

            mockRepository.Setup(c => c.GetCurrentTaxRate())
                .Returns(taxRate);

            var service = new TaxService(mockRepository.Object);

            var salaryWithoutTaxes = service.CalculateSalary(salary);

            salaryWithoutTaxes.Should().Be(expected);
        }
    }
}
