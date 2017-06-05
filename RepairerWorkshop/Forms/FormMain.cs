using RepairerWorkshop.Forms;
using RepairerWorkshop.Model;
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

namespace RepairerWorkshop
{
    public partial class FormMain : Form
    {
        public static User user = new User();
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds1;
        protected DataSet ds2;
        protected DataSet ds3;
        protected DataSet ds4;
        protected SqlDataAdapter da1;
        protected SqlDataAdapter da2;
        protected SqlDataAdapter da3;
        protected SqlDataAdapter da4;

        public FormMain()
        {
            InitializeComponent();
            Form form = new FormLogin();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (User.Items.Count != 0)
            {
                if (User.Items[1].UserRole == "Stkeeper")
                {
                    itemDictionary.Enabled = false;
                    itemOrderRepair.Enabled = false;
                    itemOrderTest.Enabled = false;
                }
                if (User.Items[1].UserRole == "Repairer")
                {
                    itemDictionary.Enabled = false;
                    itemOrderAdd.Enabled = false;
                    itemOrderClose.Enabled = false;
                    itemOrderTest.Enabled = false;
                }
                if (User.Items[1].UserRole == "Tester")
                {
                    itemDictionary.Enabled = false;
                    itemOrderAdd.Enabled = false;
                    itemOrderClose.Enabled = false;
                    itemOrderRepair.Enabled = false;
                }
            }
            
        }
        private void LoadOrders()
        {
            ds1 = new DataSet();
            da1 = new SqlDataAdapter("select OrderDate, Equipment, Customer, Status from vwOrder where Status = 'open'", conn);

            ds2 = new DataSet();
            da2 = new SqlDataAdapter("select OrderDate, Equipment, Repairer, Status from vwOrder where Status = 'progress'", conn);

            ds3 = new DataSet();
            da3 = new SqlDataAdapter("select OrderDate, Equipment, Storekeeper, Status from vwOrder where Status = 'test'", conn);

            ds4 = new DataSet();
            da4 = new SqlDataAdapter("select OrderDate, Equipment, Customer, Status from vwOrder where Status = 'close'", conn);
            da1.Fill(ds1, "vwOrder");
            dgvOrderOpen.DataSource = ds1;
            dgvOrderOpen.DataMember = "vwOrder";

            da2.Fill(ds2, "vwOrder");
            dgvOrderRepair.DataSource = ds2;
            dgvOrderRepair.DataMember = "vwOrder";

            da3.Fill(ds3, "vwOrder");
            dgvOrderTest.DataSource = ds3;
            dgvOrderTest.DataMember = "vwOrder";

            da4.Fill(ds4, "vwOrder");
            dgvOrderClosed.DataSource = ds4;
            dgvOrderClosed.DataMember = "vwOrder";
        }

        private void itemDictionaryDepartment_Click(object sender, EventArgs e)
        {
            Form form = new FormDepartment();
            form.ShowDialog();
        }

        private void itemDictionaryRepairerItem_Click(object sender, EventArgs e)
        {
            Form form = new FormRepairItem();
            form.ShowDialog();
        }

        private void itemDictionaryEquipment_Click(object sender, EventArgs e)
        {
            Form form = new FormEquipment();
            form.ShowDialog();
        }

        private void itemOrderView_Click(object sender, EventArgs e)
        {
            Form form = new FormOrderView();
            form.ShowDialog();
        }

        private void itemOrderAdd_Click(object sender, EventArgs e)
        {
            Form form = new FormOrderAdd();
            form.ShowDialog();
        }
        

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormAbout();
            form.ShowDialog();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void itemOrderRepair_Click(object sender, EventArgs e)
        {
            Form form = new FormOrderRepair();
            form.ShowDialog();
        }

        private void itemOrderTest_Click(object sender, EventArgs e)
        {
            Form form = new FormOrderTest();
            form.ShowDialog();
        }

        private void itemOrderClose_Click(object sender, EventArgs e)
        {
            Form form = new FormOrderClose();
            form.ShowDialog();
        }
        bool exitfirst = true;
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitfirst)
            {
                DialogResult dialog = MessageBox.Show("Ви справді хочете вийти з програми?",
                "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    exitfirst = false;
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
                Application.Exit();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemAddRepairItem_Click(object sender, EventArgs e)
        {
            Form form = new FormAddRepairItem();
            form.ShowDialog();
        }

        private void itemProfile_Click(object sender, EventArgs e)
        {
            Form form = new FormProfile();
            form.ShowDialog();
        }
    }
}
