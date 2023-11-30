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

namespace Monager
{
    public partial class ViewIncomes : Form
    {
        public ViewIncomes()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }

        private void ViewIncomes_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayIncomes()
        {
            conn.Open();
            string query = "select * from incomeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void IncomeSearchBtn_Click_1(object sender, EventArgs e)
        {
            if (IncomeNameTb.Text == "" || IncomeCatCb.SelectedIndex == -1)
            {
                conn.Open();
                string query = "select * from expenseTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                IncomeDGV.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "Select * from incomeTable where I_User='" + Login.User + "' and I_Name = '" + IncomeNameTb.Text + "' and I_Cat = '" + IncomeCatCb.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    IncomeDGV.DataSource = ds.Tables[0];
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
