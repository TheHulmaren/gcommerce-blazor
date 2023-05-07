using GCommerce.Shared;

namespace GCommerce.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts()
    {
        try
        {
            var httpResponse =
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (httpResponse == null)
            {
                return new ServiceResponse<List<Product>>
                {
                    Success = false,
                    Message = "Null httpResponse from server."
                };
            }

            return httpResponse;
        }
        catch (Exception e)
        {
            return new ServiceResponse<List<Product>>
            {
                Success = false,
                Message = e.Message
            };
        }
    }

    public async Task<ServiceResponse<Product>> GetProductById(int productId)
    {
        //is it a good idea to use try catch here?
        try
        {
            var response =
                await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            if (response == null)
            {
                return new ServiceResponse<Product>
                {
                    Success = false,
                    // is there a better way to handle this?
                    Message = "Null response from server."
                };
            }

            return response;
        }
        catch (Exception e)
        {
            return new ServiceResponse<Product>
            {
                Success = false,
                Message = e.Message
            };
        }
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategorySlug(string categorySlug)
    {
        try
        {
            var response =
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>(
                    $"api/product/category/{categorySlug}");
            if (response == null)
            {
                return new ServiceResponse<List<Product>>
                {
                    Success = false,
                    Message = "Null response from server."
                };
            }

            return response;
        }
        catch (Exception e)
        {
            return new ServiceResponse<List<Product>>
            {
                Success = false,
                Message = e.Message
            };
        }
    }
}