using System.Data;

namespace CSharpEducation501.PostgresqlWinForm;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    string connectionString = "Server=localhost;port=5432;database=CoreCustomerDb;user Id=orcun;password=Password1;";
    void GetAllCustomers()
    {
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Select * from customers order by customerid";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        var adapter = new Npgsql.NpgsqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        dataGridView1.DataSource = dt;
        conn.Close();
    }
    private void btnList_Click(object sender, EventArgs e)
    {
        GetAllCustomers();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string customerName = txtName.Text;
        string customerSurname = txtSurname.Text;
        string city = txtCity.Text;
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Insert into customers (customername, customersurname,customercity) values (@firstName, @lastName, @city)";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@firstName", customerName);
        cmd.Parameters.AddWithValue("@lastName", customerSurname);
        cmd.Parameters.AddWithValue("@city", city);
        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Yeni müşteri başarı ile eklendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllCustomers();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        int id = int.Parse(txtId.Text);
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Delete from customers where customerid = @id";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Müşteri başarı ile silindi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllCustomers();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int id = int.Parse(txtId.Text);
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Update customers set customername = @firstName, customersurname = @lastName, customercity = @city where customerid = @id";
        var cmd = new Npgsql.NpgsqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@firstName", txtName.Text);
        cmd.Parameters.AddWithValue("@lastName", txtSurname.Text);
        cmd.Parameters.AddWithValue("@city", txtCity.Text);
        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Müşteri başarı ile güncellendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllCustomers();
    }
}