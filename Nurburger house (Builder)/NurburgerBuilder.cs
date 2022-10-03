using NurburgerHouse.NurBurger;

namespace NurburgerHouse
{
    internal class NurburgerBuilder : INurburgerBuilder
    {
        private Nurburger _nurburger;

        public NurburgerBuilder(Order order)
        {
            _nurburger = new Nurburger();
            _nurburger.BurgerOrder = order;
        }

        public INurburgerBuilder BuildAddCheese()
        {
            _nurburger.BurgerCheese = _nurburger.BurgerOrder.BurgerType switch
            {
                Order.Type.Classic => Nurburger.Cheese.Parmesan,
                Order.Type.Childrens => Nurburger.Cheese.Cream,
                _ => Nurburger.Cheese.Parmesan
            };
            
            return this;
        }

        public INurburgerBuilder BuildAddLettuce()
        {
            _nurburger.BurgerLettuce = _nurburger.BurgerOrder.BurgerType switch
            {
                Order.Type.Classic => Nurburger.Lettuce.IcebergLettuce,
                Order.Type.Childrens => Nurburger.Lettuce.GreenLeafLettuce,
                _ => Nurburger.Lettuce.RomaineLettuce
            };
            return this;
        }

        public INurburgerBuilder BuildAddMeat()
        {
            _nurburger.BurgerMeat = _nurburger.BurgerOrder.BurgerType switch
            {
                Order.Type.Classic => Nurburger.Meat.Beef,
                Order.Type.Childrens => Nurburger.Meat.Chiken,
                _ => Nurburger.Meat.Beef
            };
            return this;
        }

        public INurburgerBuilder BuildAddSauce()
        {
            _nurburger.BurgerSauce = _nurburger.BurgerOrder.BurgerType switch
            {
                Order.Type.Classic => Nurburger.Sauce.TomatoSauce,
                Order.Type.Childrens => Nurburger.Sauce.CheeseSauce,
                _ => Nurburger.Sauce.TomatoSauce
            };
            return this;
        }

        public INurburgerBuilder BuildAddTomato()
        {
            return this;
        }

        public INurburgerBuilder BuildSpicy()
        {
            _nurburger.BurgerSpicyLevel = _nurburger.BurgerOrder.BurgerType switch
            {
                Order.Type.Spicy => Nurburger.Spicy.Spicy,                
                _ => Nurburger.Spicy.NoSpicy
            };
            return this;
        }

        public Nurburger GetNurBurger()
        {
            return _nurburger;
        }
        
    }
}