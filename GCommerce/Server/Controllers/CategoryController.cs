
using Microsoft.AspNetCore.Mvc;

namespace GCommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController( ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var serviceResponse = await _categoryService.GetCategories();
            if (serviceResponse.Success)
            {
                return Ok(serviceResponse);
            }

            return NotFound(serviceResponse);
        }
    }
}
