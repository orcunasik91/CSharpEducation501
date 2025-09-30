using System.Data;

namespace CSharpEducation501.PostgresqlWinForm;
public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }
    string connectionString = "Server=localhost;port=5432;database=CoreCustomerDb;user Id=orcun;password=Password1;";
    void GetAllEmployees()
    {
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Select * from employees order by employeeid";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        var adapter = new Npgsql.NpgsqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        dataGridView1.DataSource = dt;
        conn.Close();
    }
    void DepartmentList()
    {
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Select * from departments order by departmentid";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        var adapater = new Npgsql.NpgsqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adapater.Fill(dt);
        cmbDepartment.DisplayMember = "departmentname";
        cmbDepartment.ValueMember = "departmentid";
        cmbDepartment.DataSource = dt;
        conn.Close();
    }
    private void btnList_Click(object sender, EventArgs e)
    {
        GetAllEmployees();
    }

    private void Form3_Load(object sender, EventArgs e)
    {
        GetAllEmployees();
        DepartmentList();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string employeeName = txtName.Text;
        string employeeSurname = txtSurname.Text;
        decimal salary = decimal.Parse(txtSalary.Text);
        int departmendId = Convert.ToInt32(cmbDepartment.SelectedValue);
        var conn = new Npgsql.NpgsqlConnection(connectionString);
        conn.Open();
        string query = "Insert into employees (firstname, lastname,salary,departmentid) values (@firstName, @lastName, @salary,@depid)";
        var cmd = new Npgsql.NpgsqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@firstName", employeeName);
        cmd.Parameters.AddWithValue("@lastName", employeeSurname);
        cmd.Parameters.AddWithValue("@salary", salary);
        cmd.Parameters.AddWithValue("@depid", departmendId);
        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Yeni Personel başarı ile kaydedildi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllEmployees();
    }
}