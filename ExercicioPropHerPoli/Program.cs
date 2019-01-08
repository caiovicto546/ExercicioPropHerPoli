using System;
using System.Collections.Generic;
using ExercicioPropHerPoli.Entities;

namespace ExercicioPropHerPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>();

            int qtdProd;

            Console.Write("Enter the number of products: ");
            qtdProd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i<qtdProd; i++)
            {
                char typeProd;
                string nameProd;
                double priceProd;

                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.Write("Common, used or imported (c/u/i)?");
                typeProd = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                nameProd = Console.ReadLine();
                Console.Write("Price: ");
                priceProd = double.Parse(Console.ReadLine());
                
                if (typeProd == 'i')
                {
                    double feeProd;

                    Console.Write("Customs fee: ");
                    feeProd = double.Parse(Console.ReadLine());

                    Products.Add(new ImportedProduct(nameProd, priceProd, feeProd));
                    Console.WriteLine();
                }
                else if (typeProd == 'u')
                {
                    DateTime manufactureProd;

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureProd = DateTime.Parse(Console.ReadLine());

                    Products.Add(new UsedProduct(nameProd, priceProd, manufactureProd));
                    Console.WriteLine();
                }
                else
                {
                    Products.Add(new Product(nameProd, priceProd));
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("PRICE TAGS:");

                foreach (Product prods in Products)
                {
                    Console.WriteLine(prods.PriceTag());
                }
            }
            Console.ReadLine();
        }
    }
}
