using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class RepairItem:Base<RepairItem>
    {
        public string Unit { get; set; }
        public decimal Price { get; set; }


    }
}
