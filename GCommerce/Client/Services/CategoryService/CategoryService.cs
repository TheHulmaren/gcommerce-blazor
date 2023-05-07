namespace GCommerce.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ServiceResponse<List<Category>>> GetCategories()
    {
        try
        {
            var response =
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>(
                    "api/category");
            if (response == null)
            {
                return new ServiceResponse<List<Category>>
                {
                    Success = false,
                    Message = "Null response from server."
                };
            }

            return response;
        }
        catch (Exception e)
        {
            return new ServiceResponse<List<Category>>
            {
                Success = false,
                Message = e.Message
            };
        }
    }
}