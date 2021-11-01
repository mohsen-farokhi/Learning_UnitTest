using SharedContext.Fixtures;
using System;
using Xunit;

namespace SharedContext
{
    public class UnitTest1 : IClassFixture<DatabaseFixture>
    {
        public UnitTest1(DatabaseFixture databaseFixture)
        {
            DatabaseFixture = databaseFixture;
        }

        protected DatabaseFixture DatabaseFixture { get; }

        [Fact]
        public void Test1()
        {
            var id = DatabaseFixture.RandomId;
        }

        [Fact]
        public void Test2()
        {
            var id = DatabaseFixture.RandomId;
        }
    }
}
