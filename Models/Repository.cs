using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsRazorPages;
using ProductsRazorPages.Models;
using ProductsRazorPages.Services;

namespace ProductsRazorPages
{
    public class Repository : IRepository
    {
        private List<Product> ProductList;

        public Repository()
        {
            ProductList = new List<Product>()
            {
                new Product()
                {
                    ID=1,
                    Name="Chai",
                    Category="Beverages",
                    Price=(decimal)18.00,
                    UnitsInStock=39
                },
                new Product()
                {
                    ID=2,
                    Name="Chang",
                    Category="Beverages",
                    Price=(decimal)19.00,
                    UnitsInStock=17
                },
                new Product()
                {
                    ID=3,
                    Name="Anyseed sirup",
                    Category="Condiments",
                    Price=(decimal)10.00,
                    UnitsInStock=13
                },
                new Product()
                {
                    ID=4,
                    Name="Chef anton's",
                    Category="Condiments",
                    Price=(decimal)22.00,
                    UnitsInStock=53
                },
                new Product()
                {
                    ID=5,
                    Name="Grandma",
                    Category="Produce",
                    Price=(decimal)4.00,
                    UnitsInStock=145
                }
            };
        }

        public List<Product> GetList()
        {
            return ProductList;
        }

        public Product GetProductById(int id)
        {
            return (from product in ProductList where product.ID.Equals(id) select product).FirstOrDefault();
        }
    }
}
