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
    public partial class FormOrderClose : Form
    {
        public FormOrderClose()
        {
            InitializeComponent();
        }

        private void FormOrderClose_Load(object sender, EventArgs e)
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select OrderID, EquipmentID, Equipment, Status from vwOrder where Status = 'test'";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.conn.Open();
                string query = @"update tbOrder
                                set OrderStatusName = 'close'
                                    where OrderID = @OrderID";
                // 2. define parameters used in command object
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@OrderID";
                param2.Value = ((Order)(cbOrder.SelectedItem)).ID;

                SqlCommand cmd = new SqlCommand(query, FormMain.conn);
                cmd.Parameters.Add(param2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Замовлення виконано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Замовлення не виконано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
