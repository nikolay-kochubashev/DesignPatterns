using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurburgerHouse.NurBurger
{
    internal class  Nurburger
    {
        public enum Bun { SweetBun, UnleavenedBun };
        public enum Sauce { CheeseSauce, TomatoSauce };
        public enum Cheese { Parmesan, Cream, Mozzarella, Cheddar };
        public enum Meat { Pork, Chiken, Lamb, Beef };
        public enum Lettuce { IcebergLettuce, RomaineLettuce, GreenLeafLettuce };
        public enum Spicy { NoSpicy, Spicy };

        public Bun BurgerBun;
        public Sauce BurgerSauce;
        public Cheese BurgerCheese;
        public Meat BurgerMeat;
        public Lettuce BurgerLettuce;
        public Spicy BurgerSpicyLevel;
        public Order BurgerOrder;

        public override string? ToString()
        {
            return new StringBuilder()
                .Append($"-------- Burger order {BurgerOrder.BurgerType} for {BurgerOrder.CustomerFirstName} ----------\n")
                .Append("\n")
                .Append(BurgerBun)
                .Append("\n")
                .Append(BurgerSauce)
                .Append("\n")
                .Append(BurgerCheese)
                .Append("\n")
                .Append(BurgerMeat)
                .Append("\n")
                .Append(BurgerLettuce)
                .Append("\n")
                .Append(BurgerSpicyLevel)
                .Append("\n----------------------------------------------------------------------")
                .ToString();
        }
    }
}
