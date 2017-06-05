using System.Collections.Generic;

namespace RepairerWorkshop.Model
{
    public class OrderStatus:Base<OrderStatus>
    {
        List<Order> Orders
        {
            get
            {
                var res = new List<Order>();
                foreach (var or in Order.Items.Values)
                    if (or.OrderStatus == this)
                        res.Add(or);
                return res;
            }
        }
    }
}