public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public Car() { }

    public Car(Car car)
    {
        Make = car.Make;
        Model = car.Model;
        Year = car.Year;
        Price = car.Price;
    }

    public void Accept(IShoppingCartVisitor visitor)
    {
        visitor.Visit(this);
    }
}