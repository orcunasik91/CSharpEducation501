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
            btnGetById = new Button();
            cmbCategory = new ComboBox();
            nudStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 450);
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
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 39);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(137, 395);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(163, 39);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Kaldır";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnGetById
            // 
            btnGetById.Location = new Point(137, 440);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(163, 39);
            btnGetById.TabIndex = 15;
            btnGetById.Text = "Id'ye göre Getir";
            btnGetById.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 518);
            Controls.Add(nudStock);
            Controls.Add(cmbCategory);
            Controls.Add(btnGetById);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
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
        private Button btnGetById;
        private ComboBox cmbCategory;
        private NumericUpDown nudStock;
    }
}
