using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio3.Entities;

namespace Exercicio3
{
   class Exercicio3
   {
      static void Main(string[] args)
      {
         List<TaxPayer> taxPayers = new List<TaxPayer>();

         Console.Write("Enter the number of tax payers: ");
         int n = int.Parse(Console.ReadLine());

         for(int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(type == 'i' || type == 'I')
            {
               Console.Write("Health expenditures: ");
               double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else
            {
               Console.Write("Number of employees: ");
               int numberEmployees = int.Parse(Console.ReadLine());
               taxPayers.Add(new Company(name, anualIncome, numberEmployees));
            }
         }

         Console.WriteLine("\nTAXES PAID:");
         double sum = 0.0;

         foreach(TaxPayer taxPayer in taxPayers)
         {
            double tax = taxPayer.Tax();
            Console.WriteLine(taxPayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            sum += tax;
         }

         Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
      }
   }
}