namespace CSharpEducation501.DapperWinForm
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            cmbCategory = new ComboBox();
            nudStock = new NumericUpDown();
            label6 = new Label();
            lblTotalBook = new Label();
            lblMostExpensiveBook = new Label();
            label8 = new Label();
            lblTotalDiffCategoryCount = new Label();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Ürün Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(137, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 27);
            txtId.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(137, 260);
            button1.Name = "button1";
            button1.Size = new Size(163, 39);
            button1.TabIndex = 2;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 405);
            dataGridView1.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 4;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(63, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 6;
            label3.Text = "Stok:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(137, 176);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 27);
            txtPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(61, 179);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 8;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(34, 230);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 10;
            label5.Text = "Kategori:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 305);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 39);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 39);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(137, 395);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(163, 39);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(137, 225);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(163, 28);
            cmbCategory.TabIndex = 16;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(137, 125);
            nudStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(163, 27);
            nudStock.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 30);
            label6.Name = "label6";
            label6.Size = new Size(280, 38);
            label6.TabIndex = 18;
            label6.Text = "Toplam Kitap Sayısı:";
            // 
            // lblTotalBook
            // 
            lblTotalBook.AutoSize = true;
            lblTotalBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBook.ForeColor = Color.Red;
            lblTotalBook.Location = new Point(300, 30);
            lblTotalBook.Name = "lblTotalBook";
            lblTotalBook.Size = new Size(49, 38);
            lblTotalBook.TabIndex = 19;
            lblTotalBook.Text = "00";
            // 
            // lblMostExpensiveBook
            // 
            lblMostExpensiveBook.AutoSize = true;
            lblMostExpensiveBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostExpensiveBook.ForeColor = Color.Red;
            lblMostExpensiveBook.Location = new Point(302, 92);
            lblMostExpensiveBook.Name = "lblMostExpensiveBook";
            lblMostExpensiveBook.Size = new Size(49, 38);
            lblMostExpensiveBook.TabIndex = 21;
            lblMostExpensiveBook.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(73, 92);
            label8.Name = "label8";
            label8.Size = new Size(221, 38);
            label8.TabIndex = 20;
            label8.Text = "En Pahalı Kitap:";
            // 
            // lblTotalDiffCategoryCount
            // 
            lblTotalDiffCategoryCount.AutoSize = true;
            lblTotalDiffCategoryCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDiffCategoryCount.ForeColor = Color.Red;
            lblTotalDiffCategoryCount.Location = new Point(302, 146);
            lblTotalDiffCategoryCount.Name = "lblTotalDiffCategoryCount";
            lblTotalDiffCategoryCount.Size = new Size(49, 38);
            lblTotalDiffCategoryCount.TabIndex = 23;
            lblTotalDiffCategoryCount.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 146);
            label7.Name = "label7";
            label7.Size = new Size(271, 38);
            label7.TabIndex = 22;
            label7.Text = "Kaç Farklı Kategori:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblTotalDiffCategoryCount);
            panel1.Controls.Add(lblTotalBook);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblMostExpensiveBook);
            panel1.Location = new Point(318, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 222);
            panel1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1141, 701);
            Controls.Add(panel1);
            Controls.Add(nudStock);
            Controls.Add(cmbCategory);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dapper ile Uygulama";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private ComboBox cmbCategory;
        private NumericUpDown nudStock;
        private Label label6;
        private Label lblTotalBook;
        private Label lblMostExpensiveBook;
        private Label label8;
        private Label lblTotalDiffCategoryCount;
        private Label label7;
        private Panel panel1;
    }
}
