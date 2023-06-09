namespace GCommerce.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
    Task<ServiceResponse<List<Product>>> GetProductsByCategorySlug(string categorySlug);
}