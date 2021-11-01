using SharedContext.Fixtures.Collection;
using Xunit;

namespace SharedContext
{
    [Collection("Geo")]
    public class UnitTest3
    {
        public UnitTest3(GeographyContext geographyContext)
        {
            GeographyContext = geographyContext;
        }

        protected GeographyContext GeographyContext { get; }

        [Fact]
        public void Test1()
        {
            var id = GeographyContext.RandomId;
        }

        [Fact]
        public void Test2()
        {
            var id = GeographyContext.RandomId;
        }
    }
}
