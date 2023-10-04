namespace CafeManagementPractice
{
  partial class ItemsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.Category = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.Edit = new System.Windows.Forms.Button();
      this.Delete = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.ItemPrice = new System.Windows.Forms.TextBox();
      this.Add = new System.Windows.Forms.Button();
      this.ItemName = new System.Windows.Forms.TextBox();
      this.ItemNum = new System.Windows.Forms.TextBox();
      this.ItemsGV = new System.Windows.Forms.DataGridView();
      this.label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
      this.SuspendLayout();
      // 
      // Category
      // 
      this.Category.AllowDrop = true;
      this.Category.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Category.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
      this.Category.Location = new System.Drawing.Point(133, 271);
      this.Category.Name = "Category";
      this.Category.Size = new System.Drawing.Size(194, 36);
      this.Category.TabIndex = 24;
      this.Category.Text = "Category";
      
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(1356, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 28);
      this.label1.TabIndex = 1;
      this.label1.Text = "X";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.White;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button4.ForeColor = System.Drawing.Color.MediumPurple;
      this.button4.Location = new System.Drawing.Point(28, 311);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(144, 44);
      this.button4.TabIndex = 27;
      this.button4.Text = "User";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.UseWaitCursor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.White;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button3.ForeColor = System.Drawing.Color.MediumPurple;
      this.button3.Location = new System.Drawing.Point(28, 234);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(144, 44);
      this.button3.TabIndex = 26;
      this.button3.Text = "Order";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label5.Location = new System.Drawing.Point(28, 726);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(122, 35);
      this.label5.TabIndex = 25;
      this.label5.Text = "Log Out";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 50);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(178, 117);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 24;
      this.pictureBox1.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.MediumPurple;
      this.label4.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(28, -2);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(153, 36);
      this.label4.TabIndex = 23;
      this.label4.Text = "AxA Cafe";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.Edit);
      this.panel1.Controls.Add(this.Delete);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.ItemPrice);
      this.panel1.Controls.Add(this.Add);
      this.panel1.Controls.Add(this.ItemName);
      this.panel1.Controls.Add(this.ItemNum);
      this.panel1.Controls.Add(this.ItemsGV);
      this.panel1.Controls.Add(this.Category);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Location = new System.Drawing.Point(187, 40);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1195, 732);
      this.panel1.TabIndex = 0;
      // 
      // Edit
      // 
      this.Edit.BackColor = System.Drawing.Color.MediumPurple;
      this.Edit.FlatAppearance.BorderSize = 0;
      this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Edit.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Edit.ForeColor = System.Drawing.Color.White;
      this.Edit.Location = new System.Drawing.Point(162, 575);
      this.Edit.Name = "Edit";
      this.Edit.Size = new System.Drawing.Size(88, 39);
      this.Edit.TabIndex = 38;
      this.Edit.Text = "Edit";
      this.Edit.UseVisualStyleBackColor = false;
      this.Edit.Click += new System.EventHandler(this.Edit_Click);
      // 
      // Delete
      // 
      this.Delete.BackColor = System.Drawing.Color.MediumPurple;
      this.Delete.FlatAppearance.BorderSize = 0;
      this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Delete.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Delete.ForeColor = System.Drawing.Color.White;
      this.Delete.Location = new System.Drawing.Point(256, 575);
      this.Delete.Name = "Delete";
      this.Delete.Size = new System.Drawing.Size(111, 39);
      this.Delete.TabIndex = 37;
      this.Delete.Text = "Delete";
      this.Delete.UseVisualStyleBackColor = false;
      this.Delete.Click += new System.EventHandler(this.Delete_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.BackColor = System.Drawing.Color.Transparent;
      this.label8.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label8.ForeColor = System.Drawing.Color.MediumPurple;
      this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label8.Location = new System.Drawing.Point(757, 149);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(156, 40);
      this.label8.TabIndex = 36;
      this.label8.Text = "Items List";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label7.ForeColor = System.Drawing.Color.MediumPurple;
      this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label7.Location = new System.Drawing.Point(42, 327);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(115, 28);
      this.label7.TabIndex = 35;
      this.label7.Text = "Item Price";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.ForeColor = System.Drawing.Color.MediumPurple;
      this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label6.Location = new System.Drawing.Point(42, 210);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(123, 28);
      this.label6.TabIndex = 34;
      this.label6.Text = "Item Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.MediumPurple;
      this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label2.Location = new System.Drawing.Point(42, 162);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 28);
      this.label2.TabIndex = 32;
      this.label2.Text = "Item Num";
      // 
      // ItemPrice
      // 
      this.ItemPrice.BackColor = System.Drawing.Color.White;
      this.ItemPrice.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ItemPrice.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ItemPrice.Location = new System.Drawing.Point(162, 327);
      this.ItemPrice.Name = "ItemPrice";
      this.ItemPrice.Size = new System.Drawing.Size(165, 26);
      this.ItemPrice.TabIndex = 31;
      // 
      // Add
      // 
      this.Add.BackColor = System.Drawing.Color.MediumPurple;
      this.Add.FlatAppearance.BorderSize = 0;
      this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Add.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Add.ForeColor = System.Drawing.Color.White;
      this.Add.Location = new System.Drawing.Point(68, 575);
      this.Add.Name = "Add";
      this.Add.Size = new System.Drawing.Size(88, 39);
      this.Add.TabIndex = 28;
      this.Add.Text = "Add";
      this.Add.UseVisualStyleBackColor = false;
      this.Add.Click += new System.EventHandler(this.Add_Click);
      // 
      // ItemName
      // 
      this.ItemName.BackColor = System.Drawing.Color.White;
      this.ItemName.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ItemName.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ItemName.Location = new System.Drawing.Point(162, 209);
      this.ItemName.Name = "ItemName";
      this.ItemName.Size = new System.Drawing.Size(165, 26);
      this.ItemName.TabIndex = 27;
      // 
      // ItemNum
      // 
      this.ItemNum.BackColor = System.Drawing.Color.White;
      this.ItemNum.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ItemNum.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ItemNum.Location = new System.Drawing.Point(162, 162);
      this.ItemNum.Name = "ItemNum";
      this.ItemNum.Size = new System.Drawing.Size(165, 26);
      this.ItemNum.TabIndex = 26;
      // 
      // ItemsGV
      // 
      this.ItemsGV.AllowUserToAddRows = false;
      this.ItemsGV.AllowUserToDeleteRows = false;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
      this.ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
      this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
      this.ItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ItemsGV.Location = new System.Drawing.Point(421, 194);
      this.ItemsGV.Name = "ItemsGV";
      this.ItemsGV.RowHeadersWidth = 51;
      this.ItemsGV.RowTemplate.Height = 29;
      this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ItemsGV.Size = new System.Drawing.Size(758, 420);
      this.ItemsGV.TabIndex = 25;
      this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label9.ForeColor = System.Drawing.Color.MediumPurple;
      this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label9.Location = new System.Drawing.Point(421, 32);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(279, 44);
      this.label9.TabIndex = 21;
      this.label9.Text = "Manage Items";
      // 
      // ItemsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MediumPurple;
      this.ClientSize = new System.Drawing.Size(1394, 796);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ItemsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ItemsForm";
      this.Load += new System.EventHandler(this.ItemsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private Label label1;
        private Button button4;
        private Button button3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private TextBox ItemPrice;
        private Button Add;
        private TextBox ItemName;
        private TextBox ItemNum;
        private DataGridView ItemsGV;
        private Label label9;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button Delete;
        private Button Edit;
        public ComboBox Category;
    }
}