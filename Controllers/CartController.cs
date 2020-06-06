using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;

        public CartController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Cart
        public ActionResult Index()
        {

            var results = (from item in _context.Products.ToList() where _context.Cart.Select(c => c.Product_id).Contains(item.Id) select item).ToList();
            return PartialView("_View", results);

        }
    }
}