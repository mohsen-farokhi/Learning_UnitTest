using Xunit;

namespace SharedContext.Fixtures.Collection
{
    [CollectionDefinition("Geo")]
    public class GeographyCollection : ICollectionFixture<GeographyContext>
    {
    }
}
