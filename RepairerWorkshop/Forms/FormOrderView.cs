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

namespace RepairerWorkshop.Forms
{
    public partial class FormOrderView : Form
    {
        protected SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RepairerWorkshop.Properties.Settings.dbRepaierWorkshopConnectionString"].ConnectionString);
        protected DataSet ds;
        protected SqlDataAdapter daOrder;
        protected SqlDataAdapter daHistory;
        protected SqlDataAdapter daItems;

        protected DataRelation relation;
        protected DataRelation relation1;

        protected BindingSource master = new BindingSource();
        protected BindingSource history = new BindingSource();
        protected BindingSource items = new BindingSource();

        public FormOrderView()
        {
            InitializeComponent();
        }

        private void FormOrderView_Load(object sender, EventArgs e)
        {
            dgv.DataSource = master;
            dgvHistory.DataSource = history;
            dgvOrderItems.DataSource = items;
            GetData();

            dgv.AutoResizeColumns();
            dgvHistory.AutoResizeColumns();
            dgvOrderItems.AutoResizeColumns();
        }

        private void GetData()
        {
            ds = new DataSet();
            daOrder = new SqlDataAdapter("select * from vwOrder", conn);
            daOrder.Fill(ds, "vwOrder");
            daHistory = new SqlDataAdapter("select OrderID,OldStatus,NewStatus,DateChange from tbOrderHistory", conn);
            daHistory.Fill(ds, "tbOrderHistory");
            daItems = new SqlDataAdapter("select * from vwRepairItems", conn);
            daItems.Fill(ds, "vwRepairItems");


            relation = new DataRelation("OrderOrderHistory",
                ds.Tables["vwOrder"].Columns["OrderID"],
                ds.Tables["tbOrderHistory"].Columns["OrderID"]);
            relation1 = new DataRelation("OrderItems",
                ds.Tables["vwOrder"].Columns["OrderID"],
                ds.Tables["vwRepairItems"].Columns["OrderID"]);

            ds.Relations.Add(relation);
            ds.Relations.Add(relation1);

            master.DataSource = ds;
            master.DataMember = "vwOrder";

            history.DataSource = master;
            history.DataMember = "OrderOrderHistory";

            items.DataSource = master;
            items.DataMember = "OrderItems";

        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
