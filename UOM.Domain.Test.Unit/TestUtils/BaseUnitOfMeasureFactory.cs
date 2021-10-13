namespace UOM.Domain.Test.Unit.TestUtils
{
    public class BaseUnitOfMeasureFactory
    {
        public static BaseUniOfMeasure CreateGram()
        {
            var mass = DimensionFactory.CreateMassDimension();

            var gram = 
                new BaseUniOfMeasure(id: 1, name: "Gram", symbol: "gr", dimension: mass);

            return gram;
        }
    }
}
