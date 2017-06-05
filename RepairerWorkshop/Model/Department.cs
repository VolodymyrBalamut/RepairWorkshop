using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Department:Base<Department>
    {
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

        public List<Equipment> Equipments
        {
            get
            {
                var res = new List<Equipment>();
                foreach (var eq in Equipment.Items.Values)
                    if (eq.Department == this)
                        res.Add(eq);
                return res;
            }
        }

        public List<Employee> Employees
        {
            get
            {
                var res = new List<Employee>();
                foreach (var em in Employee.Items.Values)
                    if (em.Department == this)
                        res.Add(em);
                return res;
            }
        }
    }
}
