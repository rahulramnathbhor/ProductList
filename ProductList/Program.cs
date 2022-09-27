using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    public class Program
    {

        static void Main(string[] args)
        {
          

            List<Product> list3 = new List<Product>();
            list3.Add(new Product { Id = 1, Name = "Laptop", Price = 25000 });
           

            // or

            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Price = 25000 },
                new Product { Id = 2, Name = "Laptop", Price = 25000 },
                new Product { Id = 3, Name = "Laptop", Price = 25000 },
               
            };
            //Insert, CopyTo, Sort, Reverse , IndexOf, Count, Capacity
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
          
        }
    }

   
}
