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
using Azure;
using Microsoft.VisualBasic;

namespace CafeManagementPractice
{
  public partial class ManageUsers : Form
  {
    public ManageUsers()
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
      UserOrder userorder = new UserOrder();
      userorder.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
      ItemsForm item = new ItemsForm();
      item.Show();
    }

    private void label5_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form1 login = new Form1();
      login.Show();
    }

    private void Add_Click(object sender, EventArgs e)
    {
      if (Username.Text != "" && Password.Text != "" && MobileNumber.Text != "")
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("usp_Add_User", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("Username", Username.Text.ToString());
        cmd.Parameters.AddWithValue("Password", Password.Text.ToString());
        cmd.Parameters.AddWithValue("PhoneNumber", MobileNumber.Text.ToString());
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
          MessageBox.Show("User successfully registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Username.Text = null;
          Password.Text = null;
          MobileNumber.Text = null;
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

    private void ManageUsers_Load(object sender, EventArgs e)
    {
      Populate();
    }

    private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

      Username.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
      Password.Text = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
      MobileNumber.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
    }
    public void Populate()
    {
      if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
      {
        con.Open();
      }
      SqlCommand cmd = new SqlCommand("usp_Select_User", con);
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      SqlCommandBuilder cmdbuild = new SqlCommandBuilder(adapter);
      DataTable dt = new DataTable();
      adapter.Fill(dt);
      ItemsGV.DataSource = dt;
      con.Close();
    }

    private void Delete_Click(object sender, EventArgs e)
    {
      if (Username.Text !="")
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("usp_Delete_User", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("Username", Username.Text.Trim());
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
          MessageBox.Show("User Deleted Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Username.Text = null;
          Password.Text = null;
          MobileNumber.Text = null;
          Populate();
        }
      }
      else
      {
        MessageBox.Show("Please Atleast select one row to delete","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }

    private void Edit_Click(object sender, EventArgs e)
    {
      try
      {
        if (Username.Text != "")
        {
          con.Open();
          SqlCommand cmd = new SqlCommand("usp_Update_User",con);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("Username", Username.Text);
          cmd.Parameters.AddWithValue("Password", Password.Text);
          cmd.Parameters.AddWithValue("PhoneNumber", MobileNumber.Text);
          int k= cmd.ExecuteNonQuery();
          if (k != 0)
          {
            MessageBox.Show("User Details Update Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Populate();
          }
          else
          {
           
            MessageBox.Show("Something went wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Populate();
          }
          con.Close();
        }
        else
        {
          
          MessageBox.Show("Please Enter the details to update","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
          
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
