using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class User:Base<User>
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string UserRole
        {
            get; set;
        }


    }
}
