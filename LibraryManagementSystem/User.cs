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
    public partial class User : Form
    {
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public User()
        {
            InitializeComponent();
            RefreshData();
        }

        private void quantity_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            User_label.Text = Login.UserName;

        }

        public bool CheckName()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(Name) from UserTb where Name = '" + userName_txtBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                int totalRow = 0;
                totalRow = Convert.ToInt32(cmd.ExecuteScalar());
                if (totalRow > 0)
                {
                    MessageBox.Show("This user name already exist! Try other name!");
                    return true;


                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally { con.Close(); }
            



        }

        private void user_btnSave_Click(object sender, EventArgs e)
        {
            

            if (userName_txtBox.Text == "" || phone_txtBox.Text == "" || address_txtBox.Text == "" || userPwd_txtBox.Text == "")
            {
                MessageBox.Show("Please enter your user information!");

            }else if(CheckName())
            {
                
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_INSERT_USERS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("BookID", SqlDbType.NVarChar).Value = bookName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Name", SqlDbType.NVarChar).Value = userName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Phone", SqlDbType.NVarChar).Value = phone_txtBox.Text;
                    cmd.Parameters.AddWithValue("Address", SqlDbType.NVarChar).Value = address_txtBox.Text;
                    cmd.Parameters.AddWithValue("Password", SqlDbType.Int).Value = userPwd_txtBox.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been add your user information!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    Display();
                    Reset();
                }
            }
        }

        public void Reset()
        {
            userName_txtBox.Text = "";
            phone_txtBox.Text = "";
            address_txtBox.Text = "";
            userPwd_txtBox.Text = "";
        }

        public void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM UserTb";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            user_dataGridView.DataSource = dt;
            con.Close();


        }

        public void RefreshData()
        {
            string query = "SELECT * FROM UserTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BooksTb");
            user_dataGridView.DataSource = ds.Tables[0];
        }

        private void user_btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Not found!");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this user ?", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_DELETE_USERS", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("UserID", SqlDbType.Int).Value = key;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have been deleted ID " + key + " user information!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        Display();
                        Reset();
                    }
                }

            }
        }

        private void user_btnEdit_Click(object sender, EventArgs e)
        {
            if (userName_txtBox.Text == "" || phone_txtBox.Text == "" || address_txtBox.Text == "" || userPwd_txtBox.Text == "")
            {
                MessageBox.Show("Update information cannot be empty!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_USERS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("UserID", SqlDbType.NVarChar).Value = key;
                    cmd.Parameters.AddWithValue("Name", SqlDbType.NVarChar).Value = userName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Phone", SqlDbType.NVarChar).Value = phone_txtBox.Text;
                    cmd.Parameters.AddWithValue("Address", SqlDbType.NVarChar).Value = address_txtBox.Text;
                    cmd.Parameters.AddWithValue("Password", SqlDbType.Int).Value = userPwd_txtBox.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been updated your user information!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    Display();
                    Reset();
                }
            }
        }

        int key = 0;
        private void user_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userName_txtBox.Text = user_dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
            phone_txtBox.Text = user_dataGridView.SelectedRows[0].Cells["Phone"].Value.ToString();
            address_txtBox.Text = user_dataGridView.SelectedRows[0].Cells["Address"].Value.ToString();
            userPwd_txtBox.Text = user_dataGridView.SelectedRows[0].Cells["Password"].Value.ToString();

            if (userName_txtBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(user_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void user_btnReset_Click(object sender, EventArgs e)
        {
            Reset(); 
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ManageAccount manageAccount = new ManageAccount();
            manageAccount.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
