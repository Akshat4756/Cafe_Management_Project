namespace CafeManagementPractice
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.MediumPurple;
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(416, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(363, 387);
      this.panel1.TabIndex = 0;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Segoe Fluent Icons", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new System.Drawing.Point(320, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(26, 28);
      this.label7.TabIndex = 4;
      this.label7.Text = "X";
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new System.Drawing.Point(109, 193);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(107, 31);
      this.label6.TabIndex = 3;
      this.label6.Text = "By AxA";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(25, 137);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(326, 31);
      this.label5.TabIndex = 2;
      this.label5.Text = "Cafe Management System";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.MediumPurple;
      this.label1.Location = new System.Drawing.Point(100, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(153, 36);
      this.label1.TabIndex = 1;
      this.label1.Text = "AxA Cafe";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.MediumPurple;
      this.label2.Location = new System.Drawing.Point(25, 153);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 38);
      this.label2.TabIndex = 2;
      this.label2.Text = "Username";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.MediumPurple;
      this.label3.Location = new System.Drawing.Point(25, 209);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 38);
      this.label3.TabIndex = 3;
      this.label3.Text = "Password";
      // 
      // textBox1
      // 
      this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
      this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.textBox1.Location = new System.Drawing.Point(186, 157);
      this.textBox1.Name = "textBox1";
      this.textBox1.PlaceholderText = "Enter Your Username";
      this.textBox1.Size = new System.Drawing.Size(189, 27);
      this.textBox1.TabIndex = 4;
      // 
      // textBox2
      // 
      this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
      this.textBox2.Location = new System.Drawing.Point(186, 213);
      this.textBox2.Name = "textBox2";
      this.textBox2.PlaceholderText = "Enter Your Password";
      this.textBox2.Size = new System.Drawing.Size(189, 27);
      this.textBox2.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.button1.BackColor = System.Drawing.Color.MediumPurple;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(134, 260);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(86, 33);
      this.button1.TabIndex = 6;
      this.button1.Text = "Login";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(100, 72);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(153, 78);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.MediumPurple;
      this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.label4.Location = new System.Drawing.Point(149, 296);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 34);
      this.label4.TabIndex = 8;
      this.label4.Text = "Guest";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(779, 387);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}