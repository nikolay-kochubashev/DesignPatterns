using NurburgerHouse;
using NurburgerHouse.NurBurger;

List<Order> orders = new()
{
    new Order { CustomerFirstName = "Askar", BurgerType = Order.Type.Classic },
    new Order { CustomerFirstName = "Vasiliy", BurgerType = Order.Type.Childrens },
    new Order { CustomerFirstName = "Polina", BurgerType = Order.Type.Spicy },
    new Order { CustomerFirstName = "Ayazhan", BurgerType = Order.Type.Childrens }
};

foreach (Order order in orders)
{
    INurburgerBuilder nurburgerBuilder = new NurburgerBuilder(order);
    NurburgerDirector nurburgerDirector = new NurburgerDirector(nurburgerBuilder);
    nurburgerDirector.Build();
    
    Console.WriteLine(nurburgerBuilder.GetNurBurger());
}
