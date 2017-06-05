using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Equipment:Base<Equipment>
    {
        public Equipment(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public decimal Price { get; set; }

        private int _DepartmentID;
        public Department Department
        {
            get
            {
                if (_DepartmentID == -1)
                    return null;
                return Department.Items[_DepartmentID];
            }
            set
            {
                if (value == null)
                    _DepartmentID = -1;
                else
                    _DepartmentID = value.ID;
            }
        }

        public int _EquipmentType;

        public EquipmentType EquipmentType
        {
            get
            {
                if (_EquipmentType == -1)
                    return null;
                return EquipmentType.Items[_EquipmentType];
            }
            set
            {
                if (value == null)
                    _EquipmentType = -1;
                else
                    _EquipmentType = value.ID;
            }
        }

        public override string ToString()
        {
            return  "№ " + ID.ToString() + " - " + base.ToString();
        }
    }
}
