using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
    internal class GymMembership : IMembership
    {        
        private readonly decimal _price;
        public string Name { get; }
        public string Description { get; set; }
        public decimal GetPrice() => _price;
        public GymMembership(decimal price)
        {
            Name = "Gym membership";
            _price = price;            
        }
    }
}
