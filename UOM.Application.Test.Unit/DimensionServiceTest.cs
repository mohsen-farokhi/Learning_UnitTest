using Moq;
using System;
using UOM.Application.Test.Unit.TestUtils;
using UOM.Domain.Dimensions;
using Xunit;

namespace UOM.Application.Test.Unit
{
    public class DimensionServiceTest
    {
        [Fact]
        public void Save_a_dimention_into_service()
        {
            var repository = new Mock<IDimensionRepository>();

            repository.Setup(c => c.NextId()).Returns(1);

            var service = new DimensionService(repository.Object);

            var expected = new Dimension(1, "Mass", "m");

            service.DefineDimension(new DefineDimensionDto
            {
                Name = "Mass",
                Symbol = "m",
            });

            repository.Verify
                (c => c.Add(It.Is<Dimension>
                    (c => c.Id == expected.Id &&
                    c.Name == expected.Name &&
                    c.Symbol == expected.Symbol))
                , Times.Once);
        }
    }
}
