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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            tbLogin.Text = FormMain.user.Login;
            tbPassword.Text = FormMain.user.Password;
            tbPassword2.Text = FormMain.user.Password;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbPassword2.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbPassword2.PasswordChar = '*';
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == tbPassword2.Text)
            {
                try
                {
                    FormMain.conn.Open();
                    string query = @"update tbUser
                                set Login = @Login,
                                    Password = @Password
                                    where UserID = @UserID";
                    // 2. define parameters used in command object
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@Login";
                    param1.Value = tbLogin.Text;
                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@UserID";
                    param2.Value = FormMain.user.ID;
                    SqlParameter param3 = new SqlParameter();
                    param3.ParameterName = "@Password";
                    param3.Value = tbPassword.Text;

                    SqlCommand cmd = new SqlCommand(query, FormMain.conn);
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Профіль оновлено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Профіль не оновлено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Паролі мають збігатися", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
