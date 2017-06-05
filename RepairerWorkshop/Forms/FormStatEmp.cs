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
    public partial class FormStatEmp : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter da;

        public FormStatEmp()
        {
            InitializeComponent();
            ds = new DataSet();
            da = new SqlDataAdapter(@"select EmployeeID as ID,
	                                   Substring(FirstName,1,1) + '. ' + LastName as Name,
	                                   Birth,
	                                   Department,
	                                   Age
                                from vwEmployee
                                where Age >= 60
                                order by Department", conn);
        }

        private void FormStatEmp_Load(object sender, EventArgs e)
        {
            da.Fill(ds, "vwEmployee");
            dgv.DataSource = ds;
            dgv.DataMember = "vwEmployee";
            dgv.AutoResizeColumns();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
