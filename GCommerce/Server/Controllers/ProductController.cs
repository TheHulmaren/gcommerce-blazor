using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GCommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
    {
        var serviceResponse = await _productService.GetProductsAsync();
        return Ok(serviceResponse);
    }

    [HttpGet("{productId:int}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
    {
        var serviceResponse = await _productService.GetProductByIdAsync(productId);
        if (serviceResponse.Success)
        {
            return Ok(serviceResponse);
        }

        return NotFound(serviceResponse);
    }
    
    [HttpGet("category/{categorySlug}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategorySlug(string categorySlug)
    {
        var serviceResponse = await _productService.GetProductsByCategorySlug(categorySlug);
        if (serviceResponse.Success)
        {
            return Ok(serviceResponse);
        }

        return NotFound(serviceResponse);
    }
}