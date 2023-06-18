public class ShoppingCart
{
    private List<Car> _items;

    public ShoppingCart()
    {
        _items = new List<Car>();
    }

    public void AddItem(Car car)
    {
        _items.Add(car);
    }

    public void RemoveItem(Car car)
    {
        _items.Remove(car);
    }

    public ShoppingCartMemento Save()
    {
        return new ShoppingCartMemento(_items);
    }

    public void Restore(ShoppingCartMemento memento)
    {
        _items = memento.Cars.Select(c => new Car(c)).ToList();
    }

    public List<Car> Items => _items;
}