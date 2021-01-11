using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio2.Entities;

namespace Exercicio2
{
   class Exercicio2
   {
      static void Main(string[] args)
      {
         Console.Write("Enter the number of products: ");
         int n = int.Parse(Console.ReadLine());
         List<Product> products = new List<Product>();

         for (int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char productType = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (productType == 'i' || productType == 'I')
            {
               Console.Write("Customs fee: ");
               double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               products.Add(new ImportedProduct(name, price, customsFee));
            }
            else if (productType == 'u' || productType == 'U')
            {
               Console.Write("Manufacture date (DD/MM/YYYY): ");
               DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
               products.Add(new UsedProduct(name, price, manufactureDate));
            }
            else
            {
               products.Add(new Product(name, price));
            }
         }

         foreach(Product prod in products)
         {
            Console.WriteLine(prod.PriceTag());
         }
      }
   }
}