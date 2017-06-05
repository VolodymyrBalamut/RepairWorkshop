using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Order:Base<Order>
    {
        public DateTime OrderDate { get; set; }

        private int _CustomerID;
        private int _StorekeeperID;
        private int _RepairerID;
        public int _EquipmentID;
        private int _OrderStatusID;

        public Employee Customer
        {
            get
            {
                if (_CustomerID == -1)
                    return null;
                return Employee.Items[_CustomerID];
            }
            set
            {
                if (value == null)
                    _CustomerID = -1;
                else
                    _CustomerID = value.ID;
            }
        }
        public Employee Storekeeper
        {
            get
            {
                if (_StorekeeperID == -1)
                    return null;
                return Employee.Items[_StorekeeperID];
            }
            set
            {
                if (value == null)
                    _StorekeeperID = -1;
                else
                    _StorekeeperID = value.ID;
            }
        }
        public Employee Repairer
        {
            get
            {
                if (_RepairerID == -1)
                    return null;
                return Employee.Items[_RepairerID];
            }
            set
            {
                if (value == null)
                    _RepairerID = -1;
                else
                    _RepairerID = value.ID;
            }
        }
        public Equipment Equipment
        {
            get
            {
                if (_EquipmentID == -1)
                    return null;
                return Equipment.Items[_EquipmentID];
            }
            set
            {
                if (value == null)
                    _EquipmentID = -1;
                else
                    _EquipmentID = value.ID;
            }
        }
        public OrderStatus OrderStatus
        {
            get
            {
                if (_OrderStatusID == -1)
                    return null;
                return OrderStatus.Items[_OrderStatusID];
            }
            set
            {
                if (value == null)
                    _OrderStatusID = -1;
                else
                    _OrderStatusID = value.ID;
            }
        }

        public override string ToString()
        {
            return ID + " " + Equipment.ToString();
        }
    }
}
