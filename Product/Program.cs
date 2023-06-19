using System;

class Product
{
    public string Name;
    public string Description;
    public double Price;
    public int Quantity;

    public Product(string name,string description,double price,int quantity) {
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
    }
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Product Management Console App!");
        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create a product");
            Console.WriteLine("2. Delete a product");
            Console.WriteLine("3. Update a product");
            Console.WriteLine("4. List all products");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateProduct();
                    break;
                case "2":
                    DeleteProduct();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    ListProducts();
                    break;
                case "5":
                    Console.WriteLine("GoodBye.............");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateProduct()
    {
        Console.Write("name => ");
        string name = Console.ReadLine();

        Console.Write("description => ");
        string description = Console.ReadLine();

        Console.Write("price => ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Quantity => ");
        int quantity =int.Parse(Console.ReadLine());

        Product newProduct = new Product(name, description, price,quantity);
        products.Add(newProduct);

        Console.WriteLine("Product created...");
    }

    static void DeleteProduct()
    {
        Console.Write("Enter the name of the product to delete: ");
        string name =Console.ReadLine();
        int i;
        bool exist = false;
        for(i=0;i<products.Count;i++)
        {
            if (products[i].Name == name)
            {
                products.RemoveAt(i);
                exist = true;
                break;
            }
        }
        if (!exist)
        {
            Console.WriteLine("Product with name : " + name + " is invalid");
        }

        
    }

    static void UpdateProduct()
    {
        Console.Write("Enter the name of the product to update: ");
        string name = Console.ReadLine();
        int i;
        for (i = 0; i < products.Count; i++)
        {
            if (products[i].Name == name)
            {
                Console.Write("Enter new product name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new product description: ");
                string newDescription = Console.ReadLine();

                Console.Write("Enter new product price: ");
                double newPrice = double.Parse(Console.ReadLine());

                Console.Write("Enter new product quantity: ");
                int newPages = int.Parse(Console.ReadLine());

                products[i].Name = newName;
                products[i].Description = newDescription;
                products[i].Price = newPrice;
                products[i].Quantity = newPages;

                Console.WriteLine("Product updated successfully...");
            }
        }
       if(i>=products.Count)
            Console.WriteLine("Invalid product name.");
        
    }

    static void ListProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Product {i + 1}:");
                Console.WriteLine($"Name: {products[i].Name}");
                Console.WriteLine($"Description: {products[i].Description}");
                Console.WriteLine($"Price: {products[i].Price}");
                Console.WriteLine($"Quantity: {products[i].Quantity}");
                Console.WriteLine();
            }
        }
    }
}
