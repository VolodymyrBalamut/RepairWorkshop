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

namespace RepairerWorkshop
{
    public partial class FormOrderAdd : Form
    {
        public FormOrderAdd()
        {
            InitializeComponent();
        }

        private void FormOrderAdd_Load(object sender, EventArgs e)
        {

            getCustomer();
            getStorekeeper();
            getEquipment();
        }

        private void getStorekeeper()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select * from tbEmployee where EmployeeID in (select EmployeeID from tbUser where UserRoleName = 'Stkeeper')";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, FormMain.conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                Employee.Items.Clear();

                while (rdr.Read())
                {
                    Employee temp = new Employee();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp.Name = rdr[1].ToString();
                    temp.LastName = rdr[2].ToString();
                    //словник об'єктів
                    Employee.Items.Add(temp.ID, temp);
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

            cbStorekeeper.DataSource = Employee.Items.Values.ToList();
        }

        private void getCustomer()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select * from tbEmployee";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, FormMain.conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                Employee.Items.Clear();

                while (rdr.Read())
                {
                    Employee temp = new Employee();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp.Name = rdr[1].ToString();
                    temp.LastName = rdr[2].ToString();
                    //словник об'єктів
                    Employee.Items.Add(temp.ID, temp);
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

            cbCustomer.DataSource = Employee.Items.Values.ToList();
        }

        private void getEquipment()
        {
            try
            {
                FormMain.conn.Open();
                string query = @"select * from tbEquipment";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, FormMain.conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                Equipment.Items.Clear();

                while (rdr.Read())
                {
                    Equipment temp = new Equipment(Convert.ToInt32(rdr[0]), rdr[1].ToString());
                    //словник об'єктів
                    Equipment.Items.Add(temp.ID, temp);
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

            cbEquipment.DataSource = Equipment.Items.Values.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.conn.Open();
                string query = @"insert into tbOrder
                            (CustomerID,StorekeeperID,EquipmentID)
                            values (@CustomerID,@StorekeeperID,@EquipmentID)";
                // 2. define parameters used in command object
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@CustomerID";
                param1.Value = ((Employee)(cbCustomer.SelectedItem)).ID;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@StorekeeperID";
                param2.Value = ((Employee)(cbStorekeeper.SelectedItem)).ID;
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@EquipmentID";
                param3.Value = ((Equipment)(cbEquipment.SelectedItem)).ID;

                SqlCommand cmd = new SqlCommand(query, FormMain.conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Замовлення додано", "Успіх",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
