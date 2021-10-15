using System.Collections.Generic;

namespace UOM.Application
{
    public interface IDimensionService
    {
        long DefineDimension(DefineDimensionDto dto);

        IList<DimensionDto> GetAllDimensions();

        DimensionDto GetDimension(long id);
    }
}