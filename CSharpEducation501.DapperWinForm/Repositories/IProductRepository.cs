using CSharpEducation501.DapperWinForm.Dtos;

namespace CSharpEducation501.DapperWinForm.Repositories;
public interface IProductRepository
{
    Task<List<ResultProductDto>> GetAllProductsAsync();
    Task GetByProductAsync(int id);
    Task CreateProductAsync(CreateProductDto productDto);
    Task UpdateProductAsync(UpdateProductDto productDto);
    Task DeleteProductAsync(int id);
}