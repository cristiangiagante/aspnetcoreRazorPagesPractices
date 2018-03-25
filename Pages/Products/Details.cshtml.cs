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
    public class DetailsModel : PageModel
    {
        public IRepository _Repository { get; set; }
        public Product Product { get; set; }

        public DetailsModel(IRepository repository)
        {
            _Repository = repository;
        }
        public void OnGet(int id)
        {
            Product = _Repository.GetProductById(id);
        }
    }
}