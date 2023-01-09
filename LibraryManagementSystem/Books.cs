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
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{   
    
    public partial class Books : Form
    {   
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public Books()
        {
            InitializeComponent();
            RefreshData();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            User_label.Text = Login.UserName;
        }

        private void books_btnSave_Click(object sender, EventArgs e)
        {
            if (bookName_txtBox.Text == "" || author_txtBox.Text == "" || category_comboBox.SelectedIndex == -1 || quantity_txtBox.Text == "" || price_txtBox.Text == "")
            {
                MessageBox.Show("Please enter your books information!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_INSERT_BOOKS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("BookID", SqlDbType.NVarChar).Value = bookName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Title", SqlDbType.NVarChar).Value = bookName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Author", SqlDbType.NVarChar).Value = author_txtBox.Text;
                    cmd.Parameters.AddWithValue("Category", SqlDbType.NVarChar).Value = category_comboBox.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("Quantity", SqlDbType.Int).Value = quantity_txtBox.Text;
                    cmd.Parameters.AddWithValue("Price", SqlDbType.Float).Value = price_txtBox.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been add your "+bookName_txtBox.Text +" book information!");
                    
                }catch(Exception ex)
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

        public void Display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM BooksTb";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            books_dataGridView.DataSource = dt;
            con.Close();


        }

        public void RefreshData()
        {
            string query = "SELECT * FROM BooksTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BooksTb");
            books_dataGridView.DataSource = ds.Tables[0];
        }



        public void Reset()
        {
            bookName_txtBox.Text = "";
            author_txtBox.Text = "";
            category_comboBox.SelectedIndex = -1;
            quantity_txtBox.Text = "";
            price_txtBox.Text = "";
        }

        private void bookList_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM BooksTb where Category = '" + bookList_comboBox.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BooksTb");
            books_dataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void books_btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
            bookList_comboBox.SelectedIndex = -1;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        int key = 0;
        private void books_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bookName_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Title"].Value.ToString();
            author_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Author"].Value.ToString();
            category_comboBox.SelectedItem = books_dataGridView.SelectedRows[0].Cells["Category"].Value.ToString();
            quantity_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Quantity"].Value.ToString();
            price_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Price"].Value.ToString();

            if(bookName_txtBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(books_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void books_btnDelete_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Not found!");
            }
            else
            {
                if(MessageBox.Show("Are you sure to delete this book ?", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SP_DELETE_BOOKS", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("BookID", SqlDbType.Int).Value = key;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have been deleted your " + bookName_txtBox.Text + " book information!");

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

        private void books_btnEdit_Click(object sender, EventArgs e)
        {
            if (bookName_txtBox.Text == "" || author_txtBox.Text == "" || category_comboBox.SelectedIndex == -1 || quantity_txtBox.Text == "" || price_txtBox.Text == "")
            {
                MessageBox.Show("Update information cannot be empty!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_EDIT_BOOKS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("BookID", SqlDbType.Int).Value = key;
                    cmd.Parameters.AddWithValue("Title", SqlDbType.NVarChar).Value = bookName_txtBox.Text;
                    cmd.Parameters.AddWithValue("Author", SqlDbType.NVarChar).Value = author_txtBox.Text;
                    cmd.Parameters.AddWithValue("Category", SqlDbType.NVarChar).Value = category_comboBox.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("Quantity", SqlDbType.Int).Value = quantity_txtBox.Text;
                    cmd.Parameters.AddWithValue("Price", SqlDbType.Float).Value = price_txtBox.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been updated your " + bookName_txtBox.Text + " book information!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    Display();
                    Reset();
                }
            }
        }

        private void bookList_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
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
