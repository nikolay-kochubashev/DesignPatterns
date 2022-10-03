using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooker
{
    internal class Chief : IChief
    {
        public IDictionary<int, string> GetStatues()
        {
            Dictionary<int, string> statuses = new();
            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new ();
            orders.Add(new Order { Name = "Burger", StatusId = RandomizeStatus() });
            orders.Add(new Order { Name = "Pasta", StatusId = RandomizeStatus() });
            orders.Add(new Order { Name = "Omlet", StatusId = RandomizeStatus() });
            return orders;
        }

        private static int RandomizeStatus() => new Random().Next(1, 4);
    }
}
