using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    //NuGet : .Net ortamında kullanabileceğimiz paketleri barındırır
   public class NorthwindContext :DbContext
    {
        //virtual : bir class ın içinde bir method yazıyorsun ve diyorsun ki o methodun içinde onu inherit eden yer
        // isterse o kodun içini değiştirebilsin 
        //override: üzerine yazma , istediğim zaman o methodun içeriğini değiştirmek istiyorum
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=Northwind;Trusted_Connection=true") ;
        }
        //ilişkilendirme
      public DbSet<Product> Products { get; set; } 
    }
}
