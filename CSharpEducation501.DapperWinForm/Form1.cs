using CSharpEducation501.DapperWinForm.Dtos;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CSharpEducation501.DapperWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new("Server=localhost,1434;Database=CoreCsharpEducationDapper;User Id=sa;Password=Password1;TrustServerCertificate=True;");
        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from Products";
            var datas = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = datas;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into Products (ProductName,Stock,Price, Category) values (@productName,@stock,@price,@category)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@stock", nudStock.Value);
            parameters.Add("@price", txtPrice.Text);
            parameters.Add("@category", cmbCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            Form1_Load(sender, e);
            MessageBox.Show("Yeni kitap başarıyla eklendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Kategori Açılır Menüsü
            string query = "Select Distinct Category from Products";
            var result = await connection.QueryAsync<ResultProductDto>(query);
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ProductId";
            cmbCategory.DataSource = result;
            #endregion
            #region İstatistikler
            string totalBookQuery = "Select Count(*) from Products";
            int totalBookCount = await connection.QueryFirstAsync<int>(totalBookQuery);
            lblTotalBook.Text = totalBookCount.ToString();

            string mostExpensiveBookQuery = "Select ProductName from Products where Price = (Select Max(Price) from Products) ";
            string mostExpensiveBook = await connection.QueryFirstAsync<string>(mostExpensiveBookQuery);
            lblMostExpensiveBook.Text = mostExpensiveBook;

            string totalDifferentCategoryQuery = "Select Count(Distinct(Category)) from Products";
            int totalDifferentCategoryCount = await connection.QueryFirstAsync<int>(totalDifferentCategoryQuery);
            lblTotalDiffCategoryCount.Text = totalDifferentCategoryCount.ToString();
            #endregion
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            string query = "Delete from Products where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Seçili kitap başarıyla kaldırıldı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Products set ProductName = @productName, Stock = @stock, Price = @price, Category = @category where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId",txtId.Text);
            parameters.Add("@productName", txtName.Text);
            parameters.Add("@stock", nudStock.Value);
            parameters.Add("@price", txtPrice.Text);
            parameters.Add("@category",cmbCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Seçili kitap başarıyla güncellendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
