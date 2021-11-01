using System;

namespace SharedContext.Fixtures.Collection
{
    public class GeographyContext : IDisposable
    {
        public GeographyContext()
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
