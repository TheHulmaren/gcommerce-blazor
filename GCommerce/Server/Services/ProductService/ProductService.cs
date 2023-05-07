namespace GCommerce.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = new ServiceResponse<Product>();
        var fetchedProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        if (fetchedProduct == null)
        {
            response.Success = false;
            response.Message = $"Product with Id: {id} not found.";
            return response;
        }

        response.Data = fetchedProduct;
        return response;
    }


    public async Task<ServiceResponse<List<Product>>> GetProductsByCategorySlug(string categorySlug)
    {
        var response = new ServiceResponse<List<Product>>
        {
            Data =
                await _context.Products.Where(p =>
                    p.Category.Url.ToLower().Equals(categorySlug.ToLower())).ToListAsync()
        };
        return response;
    }
}