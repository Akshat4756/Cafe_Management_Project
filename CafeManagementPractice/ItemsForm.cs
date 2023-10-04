
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeManagementPractice
{
  public partial class ItemsForm : Form
  {
    public ItemsForm()
    {
      InitializeComponent();
    }
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-RBREH2D\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;MultipleActiveResultSets=True");
    private void ItemsForm_Load(object sender, EventArgs e)
    {
      Populate();
    }

    private void label1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
      ManageUsers users = new ManageUsers();
      users.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      UserOrder userOrder = new UserOrder();
      userOrder.Show();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 login = new Form1();
      login.Show();
    }

    private void Add_Click(object sender, EventArgs e)
    {
      if (ItemNum.Text != "" && ItemName.Text != "" && ItemPrice.Text != "")
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("usp_Add_Items", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("ItemNum", ItemNum.Text.ToString());
        cmd.Parameters.AddWithValue("ItemName", ItemName.Text.ToString());
        cmd.Parameters.AddWithValue("ItemPrice", ItemPrice.Text.ToString());
        cmd.Parameters.AddWithValue("ItemCat", Category.SelectedItem.ToString());
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
          MessageBox.Show("Item successfully registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          ItemNum.Text = null;
          ItemName.Text = null;
          ItemPrice.Text = null;
          Populate();
        }
        else
        {
          MessageBox.Show("Something went wrong", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        con.Close();
      }
      else
      {
        MessageBox.Show("Please Enter the values", "Insert Please", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void Edit_Click(object sender, EventArgs e)
    {
      try
      {
        if (ItemName.Text != "")
        {
          con.Open();
          SqlCommand cmd = new SqlCommand("usp_Update_Items", con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("ItemName", ItemName.Text.ToString());
          cmd.Parameters.AddWithValue("ItemNum", ItemNum.Text.ToString());
          cmd.Parameters.AddWithValue("ItemPrice", ItemPrice.Text.ToString());
          if (Category.SelectedItem != null)
          {
            cmd.Parameters.AddWithValue("ItemCat",Category.SelectedItem.ToString());
          }
          else
          {
            MessageBox.Show("Please select the category of item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          int k = cmd.ExecuteNonQuery();
          if (k != 0)
          {
            MessageBox.Show("User Details Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Populate();
          }
          else
          {

            MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Populate();
          }
          con.Close();
        }
        else
        {

          MessageBox.Show("Please Enter the details to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    private void Delete_Click(object sender, EventArgs e)
    {
      if (ItemName.Text != "")
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("usp_Delete_Items", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("ItemName", ItemName.Text.Trim());
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
          MessageBox.Show("Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          ItemNum.Text = null;
          ItemName.Text = null;
          ItemPrice.Text = null;
          Populate();
        }
      }
      else
      {
        MessageBox.Show("Please Atleast select one row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      ItemName.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
      ItemNum.Text = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
      Category.SelectedItem= ItemsGV.SelectedRows[0].Cells[3].Value;
      ItemPrice.Text= ItemsGV.SelectedRows[0].Cells[4].Value.ToString();
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

    
  }
}
