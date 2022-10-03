using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurburgerHouse.NurBurger
{
    internal class Order
    {
        public enum Type { Classic, Spicy, Childrens }

        public string CustomerFirstName { get; set; }
        public Type BurgerType { get; set; }
    }
}
