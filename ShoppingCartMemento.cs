public class ShoppingCartMemento
{
    public List<Car> Cars { get; }

    public ShoppingCartMemento(List<Car> cars)
    {
        Cars = cars.Select(c => new Car(c)).ToList();
    }
}