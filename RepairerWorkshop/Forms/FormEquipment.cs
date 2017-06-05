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
    public partial class FormEquipment : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;
        protected SqlCommandBuilder cmdBldr;

        public FormEquipment()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbEquipment", conn);
            cmdBldr = new SqlCommandBuilder(da);
        }

        private void FormEquipment_Load(object sender, EventArgs e)
        {
            da.Fill(ds, "tbEquipment");
            dgv.DataSource = ds;
            dgv.DataMember = "tbEquipment";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tbEquipment");
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
