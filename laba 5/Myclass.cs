using System;

namespace firstProject
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many you want add products?:");
            int count = int.Parse(Console.ReadLine());
            Store store = new Store();
        
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
        
                Console.WriteLine("Enter type:");
                string type = Console.ReadLine();
        
                Console.WriteLine("Enter description:");
                string description = Console.ReadLine();
        
                Console.WriteLine("Enter price:");
                double price = double.Parse(Console.ReadLine());
                Tovar tovar = new Tovar(name, type, description, price);
                store.AddTovar(tovar);
            }
        
        
            Console.WriteLine("Enter name product, which you want find:");
        
            string nameFindProduct = Console.ReadLine();
            Tovar product;
            int index = 0;
            try
            {
                for (int i = 0; i < count; i++)
                {
                    if (store[i].Name == nameFindProduct)
                    {
                        index = i;
                        break;
                    }
                }
                product = store[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The program close, you enter incorrect number!");
                return;
            }
            if (product != null)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Type: {product.Type}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Price: {product.Price}");
            }
            else
            {
                Console.WriteLine("You enter incorrect name of product");
            }
        }
    }
}
