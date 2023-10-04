namespace CafeManagementPractice
{
  partial class UserOrder
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrder));
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.ItemsGV = new System.Windows.Forms.DataGridView();
      this.Quantity = new System.Windows.Forms.TextBox();
      this.btnPlaceOrder = new System.Windows.Forms.Button();
      this.Grd_order = new System.Windows.Forms.DataGridView();
      this.btnCart = new System.Windows.Forms.Button();
      this.SellerName = new System.Windows.Forms.TextBox();
      this.OrderNum = new System.Windows.Forms.TextBox();
      this.Category = new System.Windows.Forms.ComboBox();
      this.Amount = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Grd_order)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(1356, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "X";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.ItemsGV);
      this.panel1.Controls.Add(this.Quantity);
      this.panel1.Controls.Add(this.btnPlaceOrder);
      this.panel1.Controls.Add(this.Grd_order);
      this.panel1.Controls.Add(this.btnCart);
      this.panel1.Controls.Add(this.SellerName);
      this.panel1.Controls.Add(this.OrderNum);
      this.panel1.Controls.Add(this.Category);
      this.panel1.Controls.Add(this.Amount);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Location = new System.Drawing.Point(187, 50);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1195, 722);
      this.panel1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.MediumPurple;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(252, 97);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(78, 29);
      this.button1.TabIndex = 22;
      this.button1.Text = "Refresh";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // ItemsGV
      // 
      this.ItemsGV.AllowUserToAddRows = false;
      this.ItemsGV.AllowUserToDeleteRows = false;
      this.ItemsGV.AllowUserToResizeColumns = false;
      dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
      this.ItemsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
      this.ItemsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
      this.ItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.ItemsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.ItemsGV.DefaultCellStyle = dataGridViewCellStyle10;
      this.ItemsGV.Location = new System.Drawing.Point(431, 58);
      this.ItemsGV.Name = "ItemsGV";
      this.ItemsGV.ReadOnly = true;
      this.ItemsGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.ItemsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
      this.ItemsGV.RowHeadersWidth = 51;
      dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ItemsGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
      this.ItemsGV.RowTemplate.Height = 29;
      this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ItemsGV.Size = new System.Drawing.Size(732, 228);
      this.ItemsGV.TabIndex = 21;
      this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
      // 
      // Quantity
      // 
      this.Quantity.BackColor = System.Drawing.Color.White;
      this.Quantity.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Quantity.ForeColor = System.Drawing.SystemColors.WindowText;
      this.Quantity.Location = new System.Drawing.Point(699, 304);
      this.Quantity.Name = "Quantity";
      this.Quantity.PlaceholderText = "Quantity";
      this.Quantity.Size = new System.Drawing.Size(165, 26);
      this.Quantity.TabIndex = 20;
      // 
      // btnPlaceOrder
      // 
      this.btnPlaceOrder.BackColor = System.Drawing.Color.MediumPurple;
      this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
      this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPlaceOrder.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
      this.btnPlaceOrder.Location = new System.Drawing.Point(699, 663);
      this.btnPlaceOrder.Name = "btnPlaceOrder";
      this.btnPlaceOrder.Size = new System.Drawing.Size(176, 29);
      this.btnPlaceOrder.TabIndex = 19;
      this.btnPlaceOrder.Text = "Place Your Order";
      this.btnPlaceOrder.UseVisualStyleBackColor = false;
      // 
      // Grd_order
      // 
      dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
      this.Grd_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
      this.Grd_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Grd_order.BackgroundColor = System.Drawing.Color.White;
      this.Grd_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Grd_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle14.BackColor = System.Drawing.Color.MediumPurple;
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.Grd_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
      this.Grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Grd_order.Location = new System.Drawing.Point(431, 412);
      this.Grd_order.Name = "Grd_order";
      this.Grd_order.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Grd_order.RowHeadersWidth = 51;
      this.Grd_order.RowTemplate.Height = 29;
      this.Grd_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.Grd_order.Size = new System.Drawing.Size(732, 242);
      this.Grd_order.TabIndex = 18;
      // 
      // btnCart
      // 
      this.btnCart.BackColor = System.Drawing.Color.MediumPurple;
      this.btnCart.FlatAppearance.BorderSize = 0;
      this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCart.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnCart.ForeColor = System.Drawing.Color.White;
      this.btnCart.Location = new System.Drawing.Point(900, 304);
      this.btnCart.Name = "btnCart";
      this.btnCart.Size = new System.Drawing.Size(144, 29);
      this.btnCart.TabIndex = 17;
      this.btnCart.Text = "Add To Cart";
      this.btnCart.UseVisualStyleBackColor = false;
      this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
      // 
      // SellerName
      // 
      this.SellerName.BackColor = System.Drawing.Color.White;
      this.SellerName.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.SellerName.ForeColor = System.Drawing.SystemColors.WindowText;
      this.SellerName.Location = new System.Drawing.Point(52, 213);
      this.SellerName.Name = "SellerName";
      this.SellerName.PlaceholderText = "Seller Name";
      this.SellerName.Size = new System.Drawing.Size(165, 26);
      this.SellerName.TabIndex = 16;
      // 
      // OrderNum
      // 
      this.OrderNum.BackColor = System.Drawing.Color.White;
      this.OrderNum.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OrderNum.ForeColor = System.Drawing.SystemColors.WindowText;
      this.OrderNum.Location = new System.Drawing.Point(52, 158);
      this.OrderNum.Name = "OrderNum";
      this.OrderNum.PlaceholderText = "Order Num";
      this.OrderNum.Size = new System.Drawing.Size(165, 26);
      this.OrderNum.TabIndex = 15;
      // 
      // Category
      // 
      this.Category.AllowDrop = true;
      this.Category.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Category.FormattingEnabled = true;
      this.Category.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
      this.Category.Location = new System.Drawing.Point(52, 92);
      this.Category.Name = "Category";
      this.Category.Size = new System.Drawing.Size(194, 36);
      this.Category.TabIndex = 13;
      this.Category.Text = "Category";
      this.Category.SelectionChangeCommitted += new System.EventHandler(this.Category_SelectionChangeCommitted);
      // 
      // Amount
      // 
      this.Amount.AutoSize = true;
      this.Amount.BackColor = System.Drawing.Color.Transparent;
      this.Amount.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.Amount.ForeColor = System.Drawing.Color.MediumPurple;
      this.Amount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.Amount.Location = new System.Drawing.Point(900, 657);
      this.Amount.Name = "Amount";
      this.Amount.Size = new System.Drawing.Size(209, 35);
      this.Amount.TabIndex = 12;
      this.Amount.Text = "Order Amount";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.MediumPurple;
      this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label2.Location = new System.Drawing.Point(758, 356);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(205, 44);
      this.label2.TabIndex = 11;
      this.label2.Text = "Your Order";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label9.ForeColor = System.Drawing.Color.MediumPurple;
      this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label9.Location = new System.Drawing.Point(431, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(217, 44);
      this.label9.TabIndex = 10;
      this.label9.Text = "Place Order";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.MediumPurple;
      this.label4.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(28, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(153, 36);
      this.label4.TabIndex = 12;
      this.label4.Text = "AxA Cafe";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 61);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(178, 117);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 13;
      this.pictureBox1.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label5.Location = new System.Drawing.Point(28, 737);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(122, 35);
      this.label5.TabIndex = 14;
      this.label5.Text = "Log Out";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.White;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button3.ForeColor = System.Drawing.Color.MediumPurple;
      this.button3.Location = new System.Drawing.Point(28, 245);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(144, 44);
      this.button3.TabIndex = 21;
      this.button3.Text = "Items";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.White;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.button4.ForeColor = System.Drawing.Color.MediumPurple;
      this.button4.Location = new System.Drawing.Point(28, 322);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(144, 44);
      this.button4.TabIndex = 22;
      this.button4.Text = "User";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // UserOrder
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
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "UserOrder";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "UserOrder";
      this.Load += new System.EventHandler(this.UserOrder_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Grd_order)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox Quantity;
        private Button btnPlaceOrder;
        private DataGridView Grd_order;
        private Button btnCart;
        private TextBox SellerName;
        private TextBox OrderNum;
        private ComboBox Category;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button3;
        private Button button4;
        private DataGridView ItemsGV;
    private Label Amount;
        private Button button1;
    }
}