using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Monager.mdf;Integrated Security=True;Connect Timeout=30");
        public static string User;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Fill all the data!");
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from userTable where U_Name='" + usernameTb.Text + "' and U_Password='" + passwordTb.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = usernameTb.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                    usernameTb.Text = "";
                    passwordTb.Text = "";
                }
                conn.Close();
            }
        }
    }
}
