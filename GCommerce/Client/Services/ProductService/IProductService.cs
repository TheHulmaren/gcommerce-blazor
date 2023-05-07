
namespace GCommerce.Client.Services.ProductService;

public interface IProductService
{
    
    Task<ServiceResponse<List<Product>>> GetProducts();
    Task<ServiceResponse<Product>> GetProductById(int id);
    Task<ServiceResponse<List<Product>>> GetProductsByCategorySlug(string categorySlug);
}