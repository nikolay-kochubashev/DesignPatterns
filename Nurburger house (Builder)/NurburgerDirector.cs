using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurburgerHouse
{
    internal class NurburgerDirector
    {
        private readonly INurburgerBuilder _builder;

        public NurburgerDirector(INurburgerBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildAddCheese()
                .BuildAddTomato()
                .BuildAddLettuce()
                .BuildAddMeat()
                .BuildAddSauce()
                .BuildSpicy();
        }
    }
}
