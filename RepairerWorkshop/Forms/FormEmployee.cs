using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairerWorkshop.Forms
{
    public partial class FormEmployee : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;
        protected SqlCommandBuilder cmdBldr;

        public FormEmployee()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbEmployee", conn);
            cmdBldr = new SqlCommandBuilder(da);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            da.Fill(ds, "tbEmployee");
            dgv.DataSource = ds;
            dgv.DataMember = "tbEmployee";
            dgv.AutoResizeColumns();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tbEmployee");
                MessageBox.Show("Оновлення пройшло успішоно", "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Оновлення даних не відбулося", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
