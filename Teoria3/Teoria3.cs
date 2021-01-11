using System;
using System.Globalization;
using System.Collections.Generic;
using Teoria3.Entities;
using Teoria3.Entities.Enums;

namespace Teoria3
{
   class Teoria3
   {
      static void Main(string[] args)
      {
         Console.Write("Enter the number of shapes: ");
         int n = int.Parse(Console.ReadLine());
         List<Shape> shapes = new List<Shape>();

         for (int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Shape #{i} data:");
            Console.Write("Rectangle or Circle (r/c)? ");
            char option = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (option == 'r' || option == 'R')
            {
               Console.Write("Width: ");
               double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.Write("Height: ");
               double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               shapes.Add(new Rectangle(color, width, height));
            }
            else
            {
               Console.Write("Radius: ");
               double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               shapes.Add(new Circle(color, radius));
            }
         }

         Console.WriteLine("\nSHAPE AREAS:");
         foreach(Shape shape in shapes)
         {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
         }
      }
   }
}