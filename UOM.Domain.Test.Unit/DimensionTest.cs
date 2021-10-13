using FluentAssertions;
using Xunit;

namespace UOM.Domain.Test.Unit
{
    public class DimensionTest
    {
        [Fact]
        public void measurement_constructed_properly()
        {
            var dimension =
                new Dimension(id: 1, name: "Mass", symbol: "m");

            dimension.Id.Should().Be(1);
            dimension.Name.Should().Be("Mass");
            dimension.Symbol.Should().Be("m");
        }
    }
}
