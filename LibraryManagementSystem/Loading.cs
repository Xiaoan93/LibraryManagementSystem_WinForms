using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        int startProgress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startProgress += 1;
            progressBar.Value = startProgress;
            percentage_label.Text = startProgress + "%";
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Login login  = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
