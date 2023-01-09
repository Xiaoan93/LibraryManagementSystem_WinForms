using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public Order()
        {
            InitializeComponent();
            RefreshData();
        }

        int key1 = 0, stock = 0;
        private void books_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order_BooksName_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Title"].Value.ToString();
            orderPrice_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Price"].Value.ToString();
            orderQuantity_txtBox.Text = books_dataGridView.SelectedRows[0].Cells["Quantity"].Value.ToString();
            order_BooksName_txtBox.Enabled = false;
            orderPrice_txtBox.Enabled = false;

            if (order_BooksName_txtBox.Text == "")
            {
                key1 = 0;
                stock = 0;
            }
            else
            {
                key1 = Convert.ToInt32(books_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(books_dataGridView.SelectedRows[0].Cells["Quantity"].Value.ToString());
            }
        }

        public void RefreshData()
        {
            string query = "SELECT * FROM BooksTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BooksTb");
            books_dataGridView.DataSource = ds.Tables[0];
        }

        private void btnOrderReset_Click(object sender, EventArgs e)
        {
            Reset();

        }

        public void Reset()
        {
            order_BooksName_txtBox.Text = "";
            orderPrice_txtBox.Text = "";
            orderQuantity_txtBox.Text = "";
        }

        private void Order_Load(object sender, EventArgs e)
        {
            User_label.Text = Login.UserName;
        }
        int newQty = 0;
        private void UpdateBook()
        {
            newQty = stock - Convert.ToInt32(orderQuantity_txtBox.Text);
            try
            {   
                con.Open();
                string query = "UPDATE BooksTb SET Quantity = " + newQty + "WHERE BookID = " + key1;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshData();
                Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
            bookList_comboBox.SelectedIndex = -1;
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
        float newTotal = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (Order_dataGridView.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Your shopping cart is empty!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTb VALUES ('" + User_label.Text + "', '" + newTotal + "', + '"+ localDate + "') ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thanks for your order, your order has been saved !");
                    Reset();
                    Order_dataGridView.Rows.Clear();
                    GST_name.Visible = false;
                    QST_name.Visible = false;
                    totalprice_name.Visible = false;
                    GST_label.Visible = false;
                    QST_label.Visible = false;
                    totalPrice_label.Visible = false;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            OrderHistory orderhistory = new OrderHistory();
            orderhistory.Show();
            this.Hide();
        }


        DateTime localDate = DateTime.Now;

        private void panel5_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        int total = 0;
        int n = 0;
        float totalPrice = 0, GST = 0, QST = 0;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            if(order_BooksName_txtBox.Text == "" || orderPrice_txtBox.Text == "")
            {
                MessageBox.Show("Please fill up books information !");
            }
            else if (orderQuantity_txtBox.Text == "" )
            {
                MessageBox.Show("Please select your quantity !"); 
            }
            else if(Convert.ToInt32(orderQuantity_txtBox.Text) > stock)
            {
                MessageBox.Show("Books Quantity not enough !");
            }
            else if(Convert.ToInt32(orderQuantity_txtBox.Text) == 0)
            {
                MessageBox.Show("This book stock is empty now !");
            }
            else
            {
                try
                {
                    total = Convert.ToInt32(orderQuantity_txtBox.Text) * Convert.ToInt32(orderPrice_txtBox.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(Order_dataGridView);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = order_BooksName_txtBox.Text;
                    newRow.Cells[2].Value = orderPrice_txtBox.Text;
                    newRow.Cells[3].Value = orderQuantity_txtBox.Text;
                    newRow.Cells[4].Value = total;
                    newRow.Cells[5].Value = localDate;
                    Order_dataGridView.Rows.Add(newRow);
                    UpdateBook();
                    totalPrice = totalPrice + total;
                    GST = (float)(totalPrice * 0.05);
                    GST_label.Text = "$" + GST;
                    QST = (float)(totalPrice * 0.09975);
                    newTotal = totalPrice + GST + QST;
                    QST_label.Text = "$" + QST;
                    totalPrice_label.Text = "$" + Math.Round(newTotal, 2);
                    GST_name.Visible = true;
                    QST_name.Visible = true;
                    totalprice_name.Visible = true;
                    GST_label.Visible = true;
                    QST_label.Visible = true;
                    totalPrice_label.Visible = true;
                    n++;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
