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
        public IActionResult Post(DefineDimensionDto dto)
        {
            _dimensionService.DefineDimension(dto);
            return Ok();
        }

        [HttpGet("{id}")]
        public DimensionDto Get(long id)
        {
            return _dimensionService.GetDimension(id);
        }

    }
}
