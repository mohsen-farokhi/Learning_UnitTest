using System.Collections.Generic;

namespace UOM.Application
{
    public interface IDimensionService
    {
        void DefineDimension(DefineDimensionDto dto);

        IList<DimensionDto> GetAllDimensions();

        DimensionDto GetDimension(long id);
    }
}