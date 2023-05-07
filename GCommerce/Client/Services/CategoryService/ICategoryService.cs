namespace GCommerce.Client.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories();
}