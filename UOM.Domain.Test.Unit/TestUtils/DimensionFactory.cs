using UOM.Domain.Dimensions;

namespace UOM.Domain.Test.Unit.TestUtils
{
    internal class DimensionFactory
    {
        public static Dimension CreateMassDimension()
        {
            return new Dimension(name: "Mass", symbol: "m");
        }
    }
}
