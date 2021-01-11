using Teoria3.Entities.Enums;

namespace Teoria3.Entities
{
   abstract class Shape
   {
      Color Color { get; set; }

      protected Shape()
      {
      }

      protected Shape(Color color)
      {
         Color = color;
      }

      public abstract double Area();
   }
}