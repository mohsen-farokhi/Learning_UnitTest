using FluentAssertions;
using Moq;
using UOM.Domain.Dimensions;
using UOM.Persistence.EF;
using UOM.Persistence.EF.Repositories;
using Xunit;

namespace UOM.Application.Test.Integration
{
    public class DimensionServiceTest : PersistTest<UomContext>
    {
        [Fact]
        public void Save_a_dimention_into_service()
        {
            var repository = new DimensionRepository(DbContext);
            var service = new DimensionService(repository);

            var expected = new Dimension("Mass", "m");

            var id = service.DefineDimension(new DefineDimensionDto
            {
                Name = "Mass",
                Symbol = "m",
            });

            this.DetachAllEntities();

            var actual = repository.GetById(id);

            actual.Should().BeEquivalentTo(expected, c => c.Excluding(e => e.Id));
        }
    }
}
