using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Position:Base<Position>
    {
        public string Description { get; set; }
        public decimal Salary { get; set; }

        public List<Employee> Employees
        {
            get
            {
                var res = new List<Employee>();
                foreach (var em in Employee.Items.Values)
                    if (em.Position == this)
                        res.Add(em);
                return res;
            }
        }
    }
}
