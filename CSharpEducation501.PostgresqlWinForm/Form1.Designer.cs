namespace CSharpEducation501.PostgresqlWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            btnList = new Button();
            txtCity = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 369);
            dataGridView1.TabIndex = 34;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSpringGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(146, 333);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 48);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(146, 279);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(184, 48);
            btnRemove.TabIndex = 32;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(146, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 48);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.SaddleBrown;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.ForeColor = SystemColors.ButtonHighlight;
            btnList.Location = new Point(146, 171);
            btnList.Name = "btnList";
            btnList.Size = new Size(184, 48);
            btnList.TabIndex = 30;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10.2F);
            txtCity.Location = new Point(146, 119);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 30);
            txtCity.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(90, 119);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 24;
            label4.Text = "Şehir:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 10.2F);
            txtSurname.Location = new Point(146, 81);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(184, 30);
            txtSurname.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 22;
            label3.Text = "Müşteri Soyadı:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F);
            txtName.Location = new Point(146, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 30);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(41, 52);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 20;
            label2.Text = "Müşteri Adı:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10.2F);
            txtId.Location = new Point(146, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(184, 30);
            txtId.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(51, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 18;
            label1.Text = "Müşteri Id:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1214, 391);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PostgreSql Uygulama";
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
        private TextBox txtCity;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}
