using FluentAssertions;
using UOM.Domain.Test.Unit.TestUtils;
using UOM.Domain.UniOfMeasures;
using Xunit;

namespace UOM.Domain.Test.Unit
{
    public class BaseUnitOfMeasureTest
    {
        [Fact]
        public void Base_unit_of_measure_is_defined_in_a_dimension()
        {
            var mass = DimensionFactory.CreateMassDimension();

            var gram =
                new BaseUniOfMeasure(id: 1, name: "Gram", symbol: "gr", dimension: mass);

            gram.DimensionId.Should().Be(mass.Id);
            gram.Id.Should().Be(1);
            gram.Name.Should().Be("Gram");
            gram.Symbol.Should().Be("gr");
        }
    }
}
