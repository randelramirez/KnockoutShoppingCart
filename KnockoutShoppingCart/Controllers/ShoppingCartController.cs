using KnockoutShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace KnockoutShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestData()
        {
            DataContext context = new DataContext();
            var model = context.Categories.Include(c => c.Products)
                .Select(s => new { 
                    Id = s.Id,
                    Name = s.Name,
                    Products = s.Products.Select(p => new {Id = p.Id, Name = p.Name, Price = p.Price, CategoryId = p.CategoryId})
                }); 
            
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public RedirectToRouteResult Save(List<SalesOrderDetail> items)
        { 
            return RedirectToAction("Index");
        }
    }
}