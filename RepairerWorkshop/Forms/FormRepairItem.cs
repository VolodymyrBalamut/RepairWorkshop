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
    public partial class FormRepairItem : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;
        protected SqlCommandBuilder cmdBldr;

        public FormRepairItem()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbRepairItem", conn);
            cmdBldr = new SqlCommandBuilder(da);
        }

        private void FormRepairItem_Load(object sender, EventArgs e)
        {
            da.Fill(ds, "tbRepairItem");
            dgv.DataSource = ds;
            dgv.DataMember = "tbRepairItem";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tbRepairItem");
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
