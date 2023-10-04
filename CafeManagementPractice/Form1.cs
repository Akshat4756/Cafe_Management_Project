using System.Threading.Tasks;
using System.Windows.Forms;
namespace CafeManagementPractice
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label7_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void label4_Click(object sender, EventArgs e)
    {
      this.Hide();
      GuestOrder itemForm = new GuestOrder();
      itemForm.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      UserOrder User = new UserOrder();
      User.Show();
    }
  }
}