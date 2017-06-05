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
    public partial class FormStatDepType : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;
        public FormStatDepType()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter(@"select Department, EquipmentType, count(*) [Count of Equipment] from vwEquipment 
                                        group by Department, EquipmentType
                                        order by Department, EquipmentType", conn);
        }

        private void FormStatDepType_Load(object sender, EventArgs e)
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
