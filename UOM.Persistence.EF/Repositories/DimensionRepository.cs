using System;
using UOM.Domain.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly UomContext _uomContext;

        public DimensionRepository(UomContext uomContext)
        {
            _uomContext = uomContext;
        }

        public void Add(Dimension dimension)
        {
            _uomContext.Add(dimension);
            _uomContext.SaveChanges();
        }

        public Dimension GetById(long id)
        {
            return _uomContext.Dimensions.Find(id);
        }

        public long NextId()
        {
            return 1;// new Random().Next(1, 9999);
        }
    }
}
