using System.Linq;
using System.Web.Mvc;
using OnlineStore.Models;
using System.Web.UI.WebControls;

namespace OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Products
        public ActionResult Index()
        {

            var products = _context.Products.ToList();

            return View("CatalogPage", products);
        }


        public ActionResult Details(int id)
        {
            var productIndb = _context.Products.SingleOrDefault(p => p.Id == id);
            if (productIndb == null)
                return HttpNotFound();

            return View("product-page", productIndb);
        }
    }
}