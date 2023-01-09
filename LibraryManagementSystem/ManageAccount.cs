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

namespace LibraryManagementSystem
{   

    public partial class ManageAccount : Form
    {
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public ManageAccount()
        {
            InitializeComponent(); 
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            User_label.Text = Login.UserName;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(Quantity) FROM BooksTb", con);
            DataTable table = new DataTable();
            sda.Fill(table);
            booksNumber_label.Text = table.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT SUM(Amount) FROM OrderTb", con);
            DataTable table1 = new DataTable();
            sda1.Fill(table1);
            sales_label.Text = "$" + table1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Count(UserID) FROM UserTb", con);
            DataTable table2 = new DataTable();
            sda2.Fill(table2);
            people_label.Text = table2.Rows[0][0].ToString();
            con.Close();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
