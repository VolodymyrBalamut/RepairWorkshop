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
using System.Configuration;

namespace RepairerWorkshop
{
    public partial class FormDepartment : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet dsOrders;
        protected SqlDataAdapter daOrders;
        protected SqlCommandBuilder cmdBldr;

        public FormDepartment()
        {
            InitializeComponent();
            dsOrders = new DataSet();
            daOrders = new SqlDataAdapter("select * from tbDepartment", conn);
            cmdBldr = new SqlCommandBuilder(daOrders);           
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            daOrders.Fill(dsOrders, "tbDepartment");
            dgvTest.DataSource = dsOrders;
            dgvTest.DataMember = "tbDepartment";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                daOrders.Update(dsOrders, "tbDepartment");
                MessageBox.Show("Оновлення пройшло успішоно", "Оновлення", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Оновлення даних не відбулося", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
