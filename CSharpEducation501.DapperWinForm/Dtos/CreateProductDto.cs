namespace CSharpEducation501.DapperWinForm.Dtos;
public class CreateProductDto
{
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}