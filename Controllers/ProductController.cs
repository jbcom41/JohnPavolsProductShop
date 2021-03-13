using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JohnPavolsProductShop.Models;

namespace JohnPavolsProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
