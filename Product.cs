using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
   public class Product
    {
        //P.K.
        public int ProductId { get; set; }
        //F.K.
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string  QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }//vt de small int var o yüzden onun karşılığı short yaptık ,Int16 da verebilirdik
    }
}
