using RepairerWorkshop.Model;
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

namespace RepairerWorkshop.Forms
{
    public partial class FormLogin : Form
    {
        bool flag = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            getUser();
            if (User.Items.Count!=0)
            {
                flag = true;
                FormMain.user.ID = User.Items[1].ID;
                FormMain.user.Login = User.Items[1].Login;
                FormMain.user.Password = User.Items[1].Password;
                MessageBox.Show("Добрий день,  " + User.Items[1].Login, "Авторизація пройшла успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Дані введені невірно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void getUser()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select UserID, Login, Password, UserRoleName from tbUser
                                    where Login = @Login and Password = @Password";
                // 1. Instantiate a new command with a query and connection
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Login";
                param1.Value = tbLogin.Text;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Password";
                param2.Value = tbPassword.Text;

                SqlCommand cmd = new SqlCommand(query, FormMain.conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                User.Items.Clear();
                while (rdr.Read())
                {
                    User temp = new User();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp.Login = Convert.ToString(rdr[1]);
                    temp.Password = Convert.ToString(rdr[2]);
                    temp.UserRole = Convert.ToString(rdr[3]);
                    //словник об'єктів
                    User.Items.Add(temp.ID, temp);
                }
                FormMain.conn.Close();
            }
            finally
            {
                // Close the connection
                if (FormMain.conn != null)
                {
                    FormMain.conn.Close();
                }
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
                Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
