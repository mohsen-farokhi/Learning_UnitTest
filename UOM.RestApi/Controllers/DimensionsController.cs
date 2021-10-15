using Microsoft.AspNetCore.Mvc;
using UOM.Application;

namespace UOM.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DimensionsController : Controller
    {
        private readonly IDimensionService _dimensionService;

        public DimensionsController(IDimensionService dimensionService)
        {
            _dimensionService = dimensionService;
        }

        [HttpPost]
        public long Post(DefineDimensionDto dto)
        {
            var id = _dimensionService.DefineDimension(dto);
            return id;
        }

        [HttpGet("{id}")]
        public DimensionDto Get(long id)
        {
            return _dimensionService.GetDimension(id);
        }

    }
}
