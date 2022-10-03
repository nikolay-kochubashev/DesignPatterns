using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooker
{
    internal class CheifProxy : IChief
    {
        private readonly Chief _chief;
        private IDictionary<int, string>? _statuses;

        public CheifProxy(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            Console.WriteLine($"{DateTime.Now:dd.MM.yyy HH.mm:ss} GetOrders()");
            return _chief.GetOrders();
        }

        public IDictionary<int, string> GetStatues()
        {
            if (_statuses is null)
            {
                _statuses = _chief.GetStatues();
                Console.WriteLine($"{DateTime.Now:dd.MM.yyy HH.mm:ss} GetStatuses()");
            }
            
            return _statuses;
        }
    }
}
