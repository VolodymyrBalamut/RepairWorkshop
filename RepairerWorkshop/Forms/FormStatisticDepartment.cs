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
    public partial class FormStatisticDepartment : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;

        public FormStatisticDepartment()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter("select Department, count(*) [Count of Equipment] from vwEquipment group by Department order by count(*) desc", conn);
        }

        private void FormStatisticDepartment_Load(object sender, EventArgs e)
        {
            da.Fill(ds, "vwEquipment");
            dgv.DataSource = ds;
            dgv.DataMember = "vwEquipment";
            dgv.AutoResizeColumns();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
