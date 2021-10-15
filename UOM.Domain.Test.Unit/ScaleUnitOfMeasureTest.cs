using FluentAssertions;
using UOM.Domain.Test.Unit.TestUtils;
using UOM.Domain.UniOfMeasures;
using Xunit;

namespace UOM.Domain.Test.Unit
{
    public class ScaleUnitOfMeasureTest
    {

        private readonly BaseUniOfMeasure _gram;

        public ScaleUnitOfMeasureTest()
        {
            _gram = BaseUnitOfMeasureFactory.CreateGram();
        }

        [Fact]
        public void Scale_unit_of_measure_constructor_properly()
        {
            var kiloogram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Kilogram", symbol: "KG",
                conversionRate: 1000, baseUniOfMeasure: _gram);

            kiloogram.Id.Should().Be(2);
            kiloogram.Name.Should().Be("Kilogram");
            kiloogram.Symbol.Should().Be("KG");
            kiloogram.ConversionRate.Should().Be(1000);
            kiloogram.BaseUniOfMeasureId.Should().Be(_gram.Id);
        }

        [Fact]
        public void Scaled_unit_of_measure_convert_to_base_when_its_on_higher_scale()
        {
            var kiloogram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Kilogram", symbol: "KG",
                conversionRate: 1000, baseUniOfMeasure: _gram);

            var amountInBase = kiloogram.ConvertToBase(3);

            amountInBase.Should().Be(3000);
        }

        [Fact]
        public void Scaled_unit_of_measure_convert_to_base_when_its_on_smaller_scale()
        {
            var milligram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Milligram", symbol: "MG",
                conversionRate: 0.001M, baseUniOfMeasure: _gram);

            var amountInBase = milligram.ConvertToBase(3);

            amountInBase.Should().Be(0.003M);
        }

        [Fact]
        public void scaled_unit_of_measure_converts_to_bigger_scaled_unit_of_maesure()
        {
            var milligram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Milligram", symbol: "MG",
                conversionRate: 0.001M, baseUniOfMeasure: _gram);

            var kiloogram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Kilogram", symbol: "KG",
                conversionRate: 1000, baseUniOfMeasure: _gram);

            var amountInKg = milligram.ConvertTo(kiloogram, 2000);

            amountInKg.Should().Be(0.002M);
        }

        [Fact]
        public void scaled_unit_of_measure_converts_to_smaller_scaled_unit_of_maesure()
        {
            var milligram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Milligram", symbol: "MG",
                conversionRate: 0.001M, baseUniOfMeasure: _gram);

            var kiloogram =
                new ScaleUnitOfMeasure
                (id: 2, name: "Kilogram", symbol: "KG",
                conversionRate: 1000, baseUniOfMeasure: _gram);

            var amountInMg = kiloogram.ConvertTo(milligram, 2);

            amountInMg.Should().Be(2000000);
        }

    }
}
