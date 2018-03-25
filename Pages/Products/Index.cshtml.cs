using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsRazorPages.Models;
using ProductsRazorPages.Services;

namespace ProductsRazorPages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private Services.IRepository _Repository;
        public List<Product> Products { get; set; }

        public IndexModel(IRepository repository)
        {
            _Repository = repository;
        }

        public void OnGet()
        {
            Products = _Repository.GetList();
        }

        
    }
}