using System;
using System.Collections.Generic;
using System.Linq;

// Memento Pattern

class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Corolla", Year = 2018, Price = 12000m },
            new Car { Make = "Honda", Model = "Civic", Year = 2019, Price = 15000m },
            new Car { Make = "Nissan", Model = "Altima", Year = 2020, Price = 18000m }
        };

        var webShop = new WebShop();

        foreach(var car in cars)
        {
            webShop.AddItemToCart(car);
        }

        Console.WriteLine("Before checkout total price: " + webShop.GetCartTotalPrice());

        webShop.Checkout();

        Console.WriteLine("After checkout total price: " + webShop.GetCartTotalPrice());

        webShop.UndoCheckout();

        Console.WriteLine("After undoing checkout total price: " + webShop.GetCartTotalPrice());
    }
}
