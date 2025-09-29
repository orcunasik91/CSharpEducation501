using CSharpEducation501.DapperWinForm.Dtos;

namespace CSharpEducation501.DapperWinForm.Repositories;
public class ProductRepository : IProductRepository
{
    public Task CreateProductAsync(CreateProductDto productDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultProductDto>> GetAllProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetByProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProductAsync(UpdateProductDto productDto)
    {
        throw new NotImplementedException();
    }
}