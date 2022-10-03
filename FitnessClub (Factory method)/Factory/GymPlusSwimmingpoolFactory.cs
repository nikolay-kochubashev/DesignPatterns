﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Domain;

namespace FitnessClub.Factory
{
    internal class GymPlusSwimmingpoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymPlusSwimmingpoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymPlusSwimmingpoolMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
