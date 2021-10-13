using System;

namespace UOM.Domain
{
    public class ScaleUnitOfMeasure
    {
        public ScaleUnitOfMeasure
            (long id,
            string name,
            string symbol,
            decimal conversionRate,
            BaseUniOfMeasure baseUniOfMeasure)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            ConversionRate = conversionRate;
            BaseUniOfMeasureId = baseUniOfMeasure.Id;
        }

        public long Id { get; private set; }

        public string Name { get; private set; }

        public string Symbol { get; private set; }

        public decimal ConversionRate { get; private set; }

        public long BaseUniOfMeasureId { get; private set; }

        public decimal ConvertToBase(decimal amount)
        {
            return amount * ConversionRate;
        }

        public object ConvertTo(ScaleUnitOfMeasure targetUom, int amount)
        {
            var valueInBase = ConvertToBase(amount);

            return valueInBase / targetUom.ConversionRate;
        }
    }
}
