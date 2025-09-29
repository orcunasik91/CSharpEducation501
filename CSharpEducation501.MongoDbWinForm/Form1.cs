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
            MessageBox.Show("Yeni Müşteri Başarıyla Eklendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnList_Click(sender, e);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customerList = customerOperations.GetAllCustomers();
            dataGridView1.DataSource = customerList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri başarıyla silindi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnList_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            var updatedCustomer = new Customer()
            {
                CustomerId = customerId,
                FirstName = txtName.Text,
                LastName = txtSurname.Text,
                City = txtCity.Text,
                Balance = decimal.Parse(txtBalance.Text),
                ShoppingCount = int.Parse(txtShoppingCount.Text)
            };
            customerOperations.UpdateCustomer(updatedCustomer);
            MessageBox.Show("Müşteri başarıyla güncellendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnList_Click(sender, e);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            var customer = customerOperations.GetOneCustomer(customerId);
            dataGridView1.DataSource = new List<Customer>{ customer};
            ;
        }
    }
}
