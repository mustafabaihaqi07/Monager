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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            GetTotalExpense();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            expNameTb.Text = "";
            expAmountTb.Text = "";
            expCatCb.SelectedIndex = -1;
            expDescTb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (expAmountTb.Text == "" || expNameTb.Text == "" || expDescTb.Text == "" || expCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Fill All the Data!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into expenseTable(E_Name,E_Amount,E_Cat,E_Date,E_Desc,E_User)values(@EN,@EA,@EC,@EDate,@EDesc,@EU)", conn);
                    cmd.Parameters.AddWithValue("@EN", expNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", expAmountTb.Text);
                    cmd.Parameters.AddWithValue("@EC", expCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EDate", expDate.Value);
                    cmd.Parameters.AddWithValue("@EDesc", expDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Saved!");
                    conn.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetTotalExpense()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(E_Amount) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpTotalAmount.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
