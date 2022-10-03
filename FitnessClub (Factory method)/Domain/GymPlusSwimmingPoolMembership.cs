using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
    internal class GymPlusSwimmingpoolMembership : IMembership
    {
        private readonly decimal _price;
        public string Name { get; }

        public string Description { get; set; }

        public GymPlusSwimmingpoolMembership(decimal price)
        {
            Name = "Gym plus Swimmingpool membership";
            _price = price;
        }

        public decimal GetPrice() => _price;
    }
}
