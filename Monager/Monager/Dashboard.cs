using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Monager
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetTotalIncome();
            GetTotalExpense();
            GetlastExpenseDate();
            GetlastIncomeDate();
            GetNumExpense();
            GetNumIncome();
            GetHelloUser();
            GetHighestExpense();
            GetLowestExpense();
            GetHighestIncome();
            GetLowestIncome();
            Getbalance();
            GetLastIncomeDesc();
            GetLastExpenseDesc();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
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

        private void numIncomeLbl_Click(object sender, EventArgs e)
        {

        }
        int exp, inc;
        private void GetTotalIncome()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(I_Amount) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            inc = Convert.ToInt32(dt.Rows[0][0].ToString());
            IncAmountLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetTotalExpense()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(E_Amount) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            exp = Convert.ToInt32(dt.Rows[0][0].ToString());
            expAmountLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetNumExpense()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numExpenseLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetNumIncome()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numIncomeLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetlastIncomeDate()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(I_Date) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lastIncomeDate.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetlastExpenseDate()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(E_Date) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lastExpenseDate.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetHelloUser()
        {
            helloLbl.Text = "Hello " + Login.User + "!";
        }

        private void GetBalance()
        {

        }

        private void GetHighestIncome()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(I_Amount) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HighestIncomeLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void GetLowestIncome()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(I_Amount) from incomeTable where I_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LowestIncomeLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void GetHighestExpense()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(E_Amount) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HighestExpenseLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void GetLowestExpense()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(E_Amount) from expenseTable where E_User='" + Login.User + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LowestExpenseLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Getbalance()
        {
            double balance = inc - exp;
            BalanceLbl.Text = balance.ToString();
        }
        private void GetLastIncomeDesc()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT I_Desc FROM incomeTable WHERE I_Id = (SELECT MAX(I_Id) FROM incomeTable WHERE I_User = '" + Login.User + "'); ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lastIncomeLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void GetLastExpenseDesc()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT E_Desc FROM expenseTable WHERE E_Id = (SELECT MAX(E_Id) FROM expenseTable WHERE E_User = '" + Login.User + "'); ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LastExpenseLbl.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}