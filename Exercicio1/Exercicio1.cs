using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1.Entities;

namespace Exercicio1
{
   class Exercicio1
   {
      static void Main(string[] args)
      {
         Console.Write("Enter the number of employees: ");
         int n = int.Parse(Console.ReadLine());
         List<Employee> employees = new List<Employee>();


         for (int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Employee #{i} data:");
            Console.Write("Outsourced (y/n)? ");
            char outSourced = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (outSourced == 'y' || outSourced == 'Y')
            {
               Console.Write("Additional charge: ");
               double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               employees.Add(new OutsourcedEmployee(name, hours, valueHour, additionalCharge));
            }
            else
            {
               employees.Add(new Employee(name, hours, valueHour));
            }
         }

         Console.WriteLine();
         Console.WriteLine("PAYMENTS:");
         foreach (Employee emp in employees)
         {
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
         }
      }
   }
}