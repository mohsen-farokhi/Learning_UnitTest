using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Transactions;

namespace UOM.Application.Test.Integration
{
    // Test-Case SuperClass
    public abstract class PersistTest<T> : IDisposable where T : DbContext, new()
    {
        private readonly TransactionScope _scope;
        protected T DbContext;
        public PersistTest()
        {
            _scope = new TransactionScope();
            DbContext = new T();
        }

        public void DetachAllEntities()
        {
            var changeEntriesCopy = DbContext.ChangeTracker.Entries()
                .Where(c => c.State == EntityState.Added ||
                            c.State == EntityState.Modified ||
                            c.State == EntityState.Deleted)
                .ToList();

            changeEntriesCopy.ForEach(c => c.State = EntityState.Deleted);
        }

        public void Dispose()
        {
            _scope.Dispose();
            DbContext.Dispose();
        }
    }
}
