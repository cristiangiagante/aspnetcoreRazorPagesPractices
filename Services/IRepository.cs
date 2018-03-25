using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsRazorPages.Models;

namespace ProductsRazorPages.Services
{
    public interface IRepository
    {
        List<Product> GetList();
        Product GetProductById(int id);
        
    }
}
