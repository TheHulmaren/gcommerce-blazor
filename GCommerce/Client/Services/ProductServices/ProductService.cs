using GCommerce.Shared;

namespace GCommerce.Client.Services.ProductServices;

public class ProductService : IProductService
{
    private readonly HttpClient _http;
    public List<Product> Products { get; set; } = new List<Product>();

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task GetProducts()
    {
        var response = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
        Products = response?.Data ?? new List<Product>();
    }
}