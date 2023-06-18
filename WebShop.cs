public class WebShop
{
    private readonly ShoppingCart _cart;
    private ShoppingCartMemento _memento;

    public WebShop()
    {
        _cart = new ShoppingCart();
    }

    public void AddItemToCart(Car car)
    {
        _cart.AddItem(car);
    }

    public void RemoveItemFromCart(Car car)
    {
        _cart.RemoveItem(car);
    }

    public decimal GetCartTotalPrice()
    {
        var visitor = new ShoppingCartPriceVisitor();
        foreach (var car in _cart.Items)
        {
            car.Accept(visitor);
        }
        return visitor.TotalPrice;
    }

    public void Checkout()
    {
        _memento = _cart.Save();
    }

    public void UndoCheckout()
    {
        _cart.Restore(_memento);
    }

    public List<Car> GetCarsInCart()
    {
        return _cart.Items;
    }
}