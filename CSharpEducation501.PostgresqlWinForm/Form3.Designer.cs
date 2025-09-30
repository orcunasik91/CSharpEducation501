namespace CSharpEducation501.PostgresqlWinForm
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            btnList = new Button();
            txtSalary = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            label5 = new Label();
            cmbDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(340, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(907, 404);
            dataGridView1.TabIndex = 47;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSpringGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(150, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 48);
            btnUpdate.TabIndex = 46;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(150, 323);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(184, 48);
            btnRemove.TabIndex = 45;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(150, 269);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 48);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.SaddleBrown;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.ForeColor = SystemColors.ButtonHighlight;
            btnList.Location = new Point(150, 215);
            btnList.Name = "btnList";
            btnList.Size = new Size(184, 48);
            btnList.TabIndex = 43;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 10.2F);
            txtSalary.Location = new Point(150, 131);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(184, 30);
            txtSalary.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(94, 128);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 41;
            label4.Text = "Maaş:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 10.2F);
            txtSurname.Location = new Point(150, 93);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(184, 30);
            txtSurname.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(15, 93);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 39;
            label3.Text = "Personel Soyadı:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F);
            txtName.Location = new Point(150, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 30);
            txtName.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(40, 61);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 37;
            label2.Text = "Personel Adı:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10.2F);
            txtId.Location = new Point(150, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(184, 30);
            txtId.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 35;
            label1.Text = "Personel Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(48, 164);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 48;
            label5.Text = "Departman:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(150, 167);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(184, 28);
            cmbDepartment.TabIndex = 49;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1259, 445);
            Controls.Add(cmbDepartment);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(txtSalary);
            Controls.Add(label4);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnList;
        private TextBox txtSalary;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Label label5;
        private ComboBox cmbDepartment;
    }
}