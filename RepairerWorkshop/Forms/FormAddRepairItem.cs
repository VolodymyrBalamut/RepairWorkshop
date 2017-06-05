using RepairerWorkshop.Model;
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
    public partial class FormAddRepairItem : Form
    {
        public FormAddRepairItem()
        {
            InitializeComponent();
        }

        private void FormAddRepairItem_Load(object sender, EventArgs e)
        {
            getOrder();
            getRepairItem();
        }

        private void getOrder()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select OrderID, EquipmentID, Equipment, Status from vwOrder where Status = 'progress'";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, FormMain.conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                Order.Items.Clear();
                Equipment.Items.Clear();

                while (rdr.Read())
                {
                    try
                    {
                        Equipment eq = new Equipment(Convert.ToInt32(rdr[1]), Convert.ToString(rdr[2]));
                        Equipment.Items.Add(eq.ID, eq);
                    }
                    catch { }

                    Order temp = new Order();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp._EquipmentID = Convert.ToInt32(rdr[1]);
                    //словник об'єктів

                    Order.Items.Add(temp.ID, temp);
                }
                FormMain.conn.Close();
            }
            finally
            {
                // Close the connection
                if (FormMain.conn != null)
                {
                    FormMain.conn.Close();
                }
            }

            cbOrder.DataSource = Order.Items.Values.ToList();
        }

        private void getRepairItem()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select * from tbRepairItem";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, FormMain.conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                Order.Items.Clear();
                Equipment.Items.Clear();

                while (rdr.Read())
                {
                    RepairItem temp = new RepairItem();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp.Name = Convert.ToString(rdr[1]);
                    temp.Price = Convert.ToDecimal(rdr[2]);

                    //словник об'єктів

                    RepairItem.Items.Add(temp.ID, temp);
                }
                FormMain.conn.Close();
            }
            finally
            {
                // Close the connection
                if (FormMain.conn != null)
                {
                    FormMain.conn.Close();
                }
            }

            cbRepairItem.DataSource = RepairItem.Items.Values.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.conn.Open();
                string query = @"insert into tbOrderDetail
                            (OrderID,RepairItemID,Quantity)
                            values (@OrderID,@RepairItemID,@Quantity)";
                // 2. define parameters used in command object
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@OrderID";
                param1.Value = ((Order)(cbOrder.SelectedItem)).ID;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@RepairItemID";
                param2.Value = ((RepairItem)(cbRepairItem.SelectedItem)).ID;
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@Quantity";
                param3.Value = Convert.ToDecimal(tbQuantity.Text);

                SqlCommand cmd = new SqlCommand(query, FormMain.conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Замовлення додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Замовлення  не додано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
