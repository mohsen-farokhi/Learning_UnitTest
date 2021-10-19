using FluentAssertions;
using UOM.Domain.Dimensions;
using Xunit;

namespace UOM.Domain.Test.Unit
{
    public class DimensionTest
    {
        [Fact]
        public void measurement_constructed_properly()
        {
            var dimension = 
                new Dimension(name: "Mass", symbol: "m");

            dimension.Name.Should().Be("Mass");
            dimension.Symbol.Should().Be("m");
        }
    }
}
