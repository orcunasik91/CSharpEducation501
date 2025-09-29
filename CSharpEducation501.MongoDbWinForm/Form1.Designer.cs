namespace CSharpEducation501.MongoDbWinForm
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
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtBalance = new TextBox();
            label5 = new Label();
            txtShoppingCount = new TextBox();
            label6 = new Label();
            btnList = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            btnGetById = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Id:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10.2F);
            txtId.Location = new Point(158, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(184, 30);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F);
            txtName.Location = new Point(158, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 30);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(53, 68);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 2;
            label2.Text = "Müşteri Adı:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 10.2F);
            txtSurname.Location = new Point(158, 97);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(184, 30);
            txtSurname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(28, 100);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 4;
            label3.Text = "Müşteri Soyadı:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10.2F);
            txtCity.Location = new Point(158, 135);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 30);
            txtCity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(102, 135);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 6;
            label4.Text = "Şehir:";
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 10.2F);
            txtBalance.Location = new Point(158, 171);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(184, 30);
            txtBalance.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(92, 174);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 8;
            label5.Text = "Bakiye:";
            // 
            // txtShoppingCount
            // 
            txtShoppingCount.Font = new Font("Segoe UI", 10.2F);
            txtShoppingCount.Location = new Point(158, 207);
            txtShoppingCount.Name = "txtShoppingCount";
            txtShoppingCount.Size = new Size(184, 30);
            txtShoppingCount.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(31, 210);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 10;
            label6.Text = "Alışveriş Adedi:";
            // 
            // btnList
            // 
            btnList.BackColor = Color.SaddleBrown;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.ForeColor = SystemColors.ButtonHighlight;
            btnList.Location = new Point(158, 243);
            btnList.Name = "btnList";
            btnList.Size = new Size(184, 48);
            btnList.TabIndex = 12;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(158, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 48);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Crimson;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(158, 351);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(184, 48);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSpringGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(158, 405);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 48);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 479);
            dataGridView1.TabIndex = 16;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.MidnightBlue;
            btnGetById.FlatStyle = FlatStyle.Flat;
            btnGetById.ForeColor = SystemColors.ButtonHighlight;
            btnGetById.Location = new Point(158, 459);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(184, 48);
            btnGetById.TabIndex = 17;
            btnGetById.Text = "Müşteri Getir";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1137, 528);
            Controls.Add(btnGetById);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(txtShoppingCount);
            Controls.Add(label6);
            Controls.Add(txtBalance);
            Controls.Add(label5);
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
            Text = "MongoDb Uygulama";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtBalance;
        private Label label5;
        private TextBox txtShoppingCount;
        private Label label6;
        private Button btnList;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Button btnGetById;
    }
}
