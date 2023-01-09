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
    public partial class OrderHistory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=XIAOAN\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
        public OrderHistory()
        {
            InitializeComponent();
            RefreshData();
        }


        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            string query = "SELECT * FROM OrderTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BooksTb");
            orderHistory_dataGridView.DataSource = ds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshData();
            timer1.Start();
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void orderHistory_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
