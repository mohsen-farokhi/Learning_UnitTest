using System.Collections.Generic;
using UOM.Domain.Dimensions;

namespace UOM.Application
{
    // Use-Case orchestration
    public class DimensionService : IDimensionService
    {
        private readonly IDimensionRepository _repository;

        public DimensionService(IDimensionRepository repository)
        {
            _repository = repository;
        }

        public long DefineDimension(DefineDimensionDto dto)
        {
            var id = _repository.NextId();

            var dimension =
                new Dimension(id, dto.Name, dto.Symbol);

            _repository.Add(dimension);

            return id;
        }

        public IList<DimensionDto> GetAllDimensions()
        {
            throw new System.NotImplementedException();
        }

        public DimensionDto GetDimension(long id)
        {
            var dimension = _repository.GetById(id);

            return new DimensionDto
            {
                Id = dimension.Id,
                Symbol = dimension.Symbol,
                Name = dimension.Name,
            };
        }
    }
}
