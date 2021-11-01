using SharedContext.Fixtures.Collection;
using Xunit;

namespace SharedContext
{
    [Collection("Geo")]
    public class UnitTest2
    {
        public UnitTest2(GeographyContext geographyContext)
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
