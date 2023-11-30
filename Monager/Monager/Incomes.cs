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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
            GetTotalIncome();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            incNameTb.Text = "";
            incAmountTb.Text = "";
            incCatCb.SelectedIndex = 0;
            incDescTb.Text = "";
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (incAmountTb.Text == "" || incNameTb.Text == "" || incDescTb.Text == "" || incCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Fill All the Data!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into incomeTable(I_Name,I_Amount,I_Cat,I_Date,I_Desc,I_User)values(@IN,@IA,@IC,@IDate,@IDesc,@IU)", conn);
                    cmd.Parameters.AddWithValue("@IN", incNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", incAmountTb.Text);
                    cmd.Parameters.AddWithValue("@IC", incCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IDate", incDate.Value);
                    cmd.Parameters.AddWithValue("@IDesc", incDescTb.Text);
                    cmd.Parameters.AddWithValue("IU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Saved!");
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
        private void GetTotalIncome()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(I_Amount) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalIncomeLbl.Text = dt.Rows[0][0].ToString();
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
