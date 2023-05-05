namespace GCommerce.Server.Services;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
}