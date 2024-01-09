using System.Numerics;

namespace ConsoleAppTask.Models;

internal class Product
{
    private int Id = 0;
    public int Year = 0;

    public Product()
    {
        
    }
    public Product(int id, int year, string name, decimal price)
    {
        Id = id;
        Year = year;
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }

    public string GetData(string name, decimal price)
    {
        Name = name;
        Price = price;
        return $"Name: {Name}; Price: {Price}";
    }

}
