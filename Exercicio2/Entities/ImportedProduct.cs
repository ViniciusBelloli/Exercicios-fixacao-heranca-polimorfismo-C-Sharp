﻿using System.Globalization;

namespace Exercicio2.Entities
{
   class ImportedProduct : Product
   {
      public double CustomsFee { get; set; }

      public ImportedProduct()
      {
      }

      public ImportedProduct(string name, double price, double customsFee)
         : base(name, price)
      {
         CustomsFee = customsFee;
      }

      public override string PriceTag()
      {
         return Name
            + " $ "
            + (CustomsFee + Price).ToString("F2", CultureInfo.InvariantCulture)
            + " (Customs fee: $ "
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
      }
   }
}