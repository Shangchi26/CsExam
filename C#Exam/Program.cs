using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsExam
{
    internal class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        DeleteProductById();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (choice != 4);
        }

        static void AddProduct()
        {
            try
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products.Add(new Product { ProductID = id, Name = name, Price = price });

                Console.WriteLine("Product added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void DisplayProducts()
        {
            Console.WriteLine("Product Records:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        static void DeleteProductById()
        {
            Console.Write("Enter Product ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            Product productToRemove = products.Find(p => p.ProductID == id);

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine("Product deleted successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
