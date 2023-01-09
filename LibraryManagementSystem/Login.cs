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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string UserName = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {   

            if(admin_Button.Checked == true)
            {
                
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AdminTb WHERE AdminID = '" + login_userName_textBox.Text + "' and AdminPassword ='" + login_password_textBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UserName = login_userName_textBox.Text;
                    Books books = new Books();
                    books.ShowDialog();
                    this.Hide();
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Your account is invalid !");
                }
            }
            
            else if (user_Button.Checked == true)
            {
                
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserTb WHERE Name = '" + login_userName_textBox.Text + "' and Password ='" + login_password_textBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UserName = login_userName_textBox.Text;
                    Order order = new Order();
                    order.ShowDialog();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Your account is invalid !");
                }
            }
            else
            {
                MessageBox.Show("Please select your identity!");
            }
                
            
                
                
           
            
        }

        private void user_Button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
