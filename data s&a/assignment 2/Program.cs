using System;
using System.Collections.Generic;
using System.IO;

public class Product
{
    public string Type { get; set; } = "";
    public string Cut { get; set; } = "";
    public string Color { get; set; } = "";
    public string Fabric { get; set; } = "";
    public string Size { get; set; } = "";
    public string Brand { get; set; } = "";
    public double BasePrice { get; set; }

    private static readonly List<string> RareSizes = new List<string> { "XXL", "XL" };
    private static readonly List<string> ExoticColors = new List<string> { "gold", "ultra pink", "silver", "acid green" };

    public double CalculateFinalPrice()
    {
        double finalPrice = BasePrice;
        if (RareSizes.Contains(Size.ToUpper())) finalPrice += 5.0;
        if (ExoticColors.Contains(Color.ToLower())) finalPrice += 7.0;
        return finalPrice;
    }

    public override string ToString()
    {
        return $"{Type},{Cut},{Color},{Fabric},{Size},{Brand},{BasePrice}";
    }

    public static Product FromString(string data)
    {
        string[] parts = data.Split(',');
        return new Product
        {
            Type = parts[0],
            Cut = parts[1],
            Color = parts[2],
            Fabric = parts[3],
            Size = parts[4],
            Brand = parts[5],
            BasePrice = double.Parse(parts[6])
        };
    }
}

public class ProductManager
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product p) => products.Add(p);

    public bool DeleteProduct(string type, string brand)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Type == type && products[i].Brand == brand)
            {
                products.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool ModifyProduct(string type, string brand, Product newProduct)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Type == type && products[i].Brand == brand)
            {
                products[i] = newProduct;
                return true;
            }
        }
        return false;
    }

    public List<Product> FilterBySizeTypeColor(string size, string type, string color)
    {
        List<Product> result = new List<Product>();
        foreach (Product p in products)
        {
            if (p.Size == size && p.Type == type && p.Color == color)
                result.Add(p);
        }
        return result;
    }

    public void SaveToFile(string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
            foreach (var p in products)
                writer.WriteLine(p.ToString());
    }

    public void LoadFromFile(string path)
    {
        products.Clear();
        if (!File.Exists(path)) return;
        foreach (string line in File.ReadAllLines(path))
            products.Add(Product.FromString(line));
    }

    public void DisplayAll()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("no products availlable");
            return;
        }

        foreach (var p in products)
        {
            Console.WriteLine($"type: {p.Type}, brand: {p.Brand}, color: {p.Color}, size: {p.Size}, final price: ${p.CalculateFinalPrice():0.00}");
        }
    }
}

class Program
{
    static void Main()
    {
        ProductManager manager = new ProductManager();
        string filePath = "products.txt";

        while (true)
        {
            Console.WriteLine("\n--- menu ---");
            Console.WriteLine("1. add product");
            Console.WriteLine("2. delete product");
            Console.WriteLine("3. modify product");
            Console.WriteLine("4. show all products");
            Console.WriteLine("5. save to file");
            Console.WriteLine("6. load from file");
            Console.WriteLine("7. filter by size, type and color");
            Console.WriteLine("8. exit");
            Console.Write("enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Product newProduct = InputProduct();
                    manager.AddProduct(newProduct);
                    Console.WriteLine("product added");
                    break;

                case "2":
                    Console.Write("enter product type to delete: ");
                    string delType = Console.ReadLine();
                    Console.Write("enter brand: ");
                    string delBrand = Console.ReadLine();
                    if (manager.DeleteProduct(delType, delBrand))
                        Console.WriteLine("product deleted");
                    else
                        Console.WriteLine("product not found");
                    break;

                case "3":
                    Console.Write("enter product type to modify: ");
                    string modType = Console.ReadLine();
                    Console.Write("enter brand: ");
                    string modBrand = Console.ReadLine();
                    Product modified = InputProduct();
                    if (manager.ModifyProduct(modType, modBrand, modified))
                        Console.WriteLine("product modified");
                    else
                        Console.WriteLine("product not found");
                    break;

                case "4":
                    Console.WriteLine("all products:");
                    manager.DisplayAll();
                    break;

                case "5":
                    manager.SaveToFile(filePath);
                    Console.WriteLine($"data saved to file: {filePath}");
                    break;

                case "6":
                    manager.LoadFromFile(filePath);
                    Console.WriteLine("data loaded from file");
                    break;

                case "7":
                    Console.Write("size: ");
                    string fSize = Console.ReadLine();
                    Console.Write("type: ");
                    string fType = Console.ReadLine();
                    Console.Write("color: ");
                    string fColor = Console.ReadLine();
                    var results = manager.FilterBySizeTypeColor(fSize, fType, fColor);
                    if (results.Count == 0)
                    {
                        Console.WriteLine("no matching products found");
                    }
                    else
                    {
                        Console.WriteLine("matching products:");
                        foreach (var p in results)
                            Console.WriteLine($"{p.Type} - {p.Brand}, final price: ${p.CalculateFinalPrice():0.00}");
                    }
                    break;

                case "8":
                    Console.WriteLine("exiiting program");
                    return;

                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }

    static Product InputProduct()
    {
        Product p = new Product();
        Console.Write("type: "); p.Type = Console.ReadLine();
        Console.Write("cut: "); p.Cut = Console.ReadLine();
        Console.Write("color: "); p.Color = Console.ReadLine();
        Console.Write("fabric: "); p.Fabric = Console.ReadLine();
        Console.Write("size: "); p.Size = Console.ReadLine();
        Console.Write("brand: "); p.Brand = Console.ReadLine();
        Console.Write("base price: ");
        p.BasePrice = double.Parse(Console.ReadLine());
        return p;
    }
}