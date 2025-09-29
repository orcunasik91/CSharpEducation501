using CSharpEducation501.MongoDbWinForm.Models;
using CSharpEducation501.MongoDbWinForm.Services;

namespace CSharpEducation501.MongoDbWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations = new();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new()
            {
                FirstName = txtName.Text,
                LastName = txtSurname.Text,
                City = txtCity.Text,
                Balance = decimal.Parse(txtBalance.Text),
                ShoppingCount = int.Parse(txtShoppingCount.Text)
            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Yeni Müşteri Başarıyla Eklendi","Sonuç",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
