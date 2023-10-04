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
  public partial class GuestOrder : Form
  {
    public GuestOrder()
    {
      InitializeComponent();
    }
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBREH2D\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;MultipleActiveResultSets=True");
    private void label7_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    private void label4_Click(object sender, EventArgs e)
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
  }
}
