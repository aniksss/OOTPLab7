public class ShoppingCartPriceVisitor : IShoppingCartVisitor
{
    public decimal TotalPrice { get; private set; }

    public void Visit(Car car)
    {
        TotalPrice += car.Price;
    }
}