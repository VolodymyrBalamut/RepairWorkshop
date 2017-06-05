using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class EquipmentType:Base<EquipmentType>
    {
        public string Description { get; set; }
        
        public List<Equipment> Equipments
        {
            get
            {
                var res = new List<Equipment>();
                foreach (var eq in Equipment.Items.Values)
                    if (eq.EquipmentType == this)
                        res.Add(eq);
                return res;
            }
        } 
    }
}
