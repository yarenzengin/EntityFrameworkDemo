using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET : Vt' ye bağlanmayı sağlyan,kontrol etmemizi sağlayan,sorgu yazmamızı sağlayan bir kütüphane
            //bunun sayesşnde yeni veri ekleyebilir ,listeleyebilir,güncelleyebiliriz

            //Günümüzde ADO ile yazdığımız kodlar yorucu bu yüzden ntp ile ilişkiyi kolaylaştırmak ,sağlamak adına çeşitli ORM dediğimiz yapıları kullanırız
            //ORM - Object relational mapping --entity framework
            //alternatifi : NHIbernate ,Dapper(ADO.NET İN ALTERNATİFİ)

            //GetAll();
            GetProductsByCategory(1);

            

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
