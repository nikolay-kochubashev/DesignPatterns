using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attacker.Strategies
{
    internal class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack with a plunger");
        }
    }
}
