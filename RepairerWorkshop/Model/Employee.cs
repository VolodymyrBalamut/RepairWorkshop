using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Employee:Base<Employee>
    {
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Telephone { get; set; }
        public string Gender { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }

        private int _PositionID;

        public Position Position
        {
            get
            {
                if (_DepartmentID == -1)
                    return null;
                return Position.Items[_PositionID];
            }
            set
            {
                if (value == null)
                    _PositionID = -1;
                else
                    _PositionID = value.ID;
            }
        }

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
        public override string ToString()
        {
            return base.ToString() + " " + LastName;
        }
    }
}
