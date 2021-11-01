using System;

namespace SharedContext.Fixtures
{

    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            RandomId = Guid.NewGuid();
        }
        public Guid RandomId { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
