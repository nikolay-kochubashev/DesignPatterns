using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NurburgerHouse.NurBurger;

namespace NurburgerHouse
{
    internal interface INurburgerBuilder
    {
        INurburgerBuilder BuildAddMeat();
        INurburgerBuilder BuildAddTomato();
        INurburgerBuilder BuildAddLettuce();
        INurburgerBuilder BuildAddCheese();
        INurburgerBuilder BuildAddSauce();
        INurburgerBuilder BuildSpicy();
        Nurburger GetNurBurger();
    }
}
