using EfCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EfCore.DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbContexInitializer.Build();
            using (var context = new AppDbContext(DbContexInitializer.OptionsBuilder.Options))
            {
               var products=  context.Products.ToListAsync().Result;
                products.ForEach(p=>
                Console.WriteLine($"{p.Name} {p.Price}") 
                );
            }
            
        }
    }
}
