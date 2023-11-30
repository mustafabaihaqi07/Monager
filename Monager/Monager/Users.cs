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

namespace Monager
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            this.Close();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            UsernameTb.Text = "";
            PasswordTb.Text = "";
            AddressTb.Text = "";
            PhoneTb.Text = "";
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "" || PhoneTb.Text == "" || PasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Fill All the Data!");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into userTable(U_Name,U_Dob,U_Password,U_Address,U_Phone)values(@UN,@UD,@UPA,@UA,@UP)", conn);
                    cmd.Parameters.AddWithValue("@UN", UsernameTb.Text);
                    cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@UPA", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@UP", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User Registered!");
                    conn.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
