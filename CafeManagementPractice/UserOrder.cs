using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagementPractice
{
  public partial class UserOrder : Form
  {
    public UserOrder()
    {
      InitializeComponent();
    }
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBREH2D\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;MultipleActiveResultSets=True");
    private void label1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }



    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      ItemsForm items = new ItemsForm();
      items.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
      ManageUsers user = new ManageUsers();
      user.Show();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 login = new Form1();
      login.Show();
    }
    public void Populate()
    {
      if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
      {
        con.Open();
      }
      SqlCommand cmd = new SqlCommand("usp_Select_Items", con);
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      SqlCommandBuilder cmdbuild = new SqlCommandBuilder(adapter);
      DataTable dt = new DataTable();
      adapter.Fill(dt);
      ItemsGV.DataSource = dt;
      con.Close();
    }
    public void FilterByCategory()
    {
      if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
      {
        con.Open();
      }
      SqlCommand cmd = new SqlCommand("usp_SelectByCat_Items", con);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.AddWithValue("ItemCat", Category.SelectedItem.ToString());
      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      SqlCommandBuilder cmdbuild = new SqlCommandBuilder(adapter);
      DataTable dt = new DataTable();
      adapter.Fill(dt);
      ItemsGV.DataSource = dt;
      con.Close();
    }
    int num = 0;
    int price, qty, total;
    string item, cat;
    private void btnCart_Click(object sender, EventArgs e)
    {

      if (Quantity.Text == "")
      {
        MessageBox.Show("Plese Enter the quantity", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else if (flag == 0)
      {
        MessageBox.Show("Please Select the product to be ordered", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        num = num + 1;
        qty = Convert.ToInt32(Quantity.Text);
        total = price * Convert.ToInt32(Quantity.Text);
        dt.Rows.Add(num, item, cat, qty, price, total);
        Grd_order.DataSource = dt;
        flag = 0;
      }
      sum = sum + total;
      Amount.Text = "Rs " + sum.ToString();
    }
    DataTable dt = new DataTable();
    int flag = 0;

    private void Category_SelectionChangeCommitted(object sender, EventArgs e)
    {
      FilterByCategory();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Populate();
    }

    int sum = 0;
    private void UserOrder_Load(object sender, EventArgs e)
    {
      Populate();
      dt.Columns.Add("Num", typeof(int));
      dt.Columns.Add("Item", typeof(string));
      dt.Columns.Add("Category", typeof(string));
      dt.Columns.Add("Quantity", typeof(int));
      dt.Columns.Add("UnitPrice", typeof(int));
      dt.Columns.Add("Total", typeof(int));

      Grd_order.DataSource = dt;
    }

    private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (ItemsGV.SelectedRows[0].Cells[1].Value.ToString() != null)
      {
        
          item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
        
      }
      //SellerName.Text = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
      if (ItemsGV.SelectedRows[0].Cells[3].Value.ToString() != null)
      {
        cat = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
      }
      price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[4].Value);
      flag = 1;
    }



  }
}
