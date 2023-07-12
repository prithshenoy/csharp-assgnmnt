using System;
using System.Collections.Generic;


public class Products
{
    public Dictionary<string, Item> Catalogue { get; set; }

    public Products()
    {
        Catalogue = new Dictionary<string, Item>();

        //ITEM 1:DOor
        Item door = new Item
        {
            EAN = "12345678912",
            ManufacturerDetails = new Manufacturer
            {
                Name = "Red Rock Engineering Works",
                Address = "Avenue Street, US"
            },
            Variants = new List<string> { "Wood", "Iron", "Carbon" }
        };
        Catalogue.Add("Door", door);

        // Item 2: Wallpaper
        Item wallpaper = new Item
        {
            EAN = "56781234913",
            ManufacturerDetails = new Manufacturer
            {
                Name = "Smart Design Interiors",
                Address = "Downtown Calgary, Canada"
            },
            Variants = new List<string> { "Blue", "Pink", "Brown" }
        };
        Catalogue.Add("Wallpaper", wallpaper);

    }

    
}

public class Item
{
    public string EAN { get; set; }
    public Manufacturer ManufacturerDetails { get; set; }
    public List<string> Variants { get; set; }
}

public class Manufacturer
{
    public string Name { get; set; }
    public string Address { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Products products = new Products();
       
        foreach (KeyValuePair<string, Item> item in products.Catalogue)
        {
            Console.WriteLine("Item Name: " + item.Key);
            Console.WriteLine("EAN: " + item.Value.EAN);
            Console.WriteLine("Manufacturer Name: " + item.Value.ManufacturerDetails.Name);
            Console.WriteLine("Manufacturer Address: " + item.Value.ManufacturerDetails.Address);
            Console.WriteLine("Variants: " + string.Join(", ", item.Value.Variants));
            Console.WriteLine();
        }

    }
}