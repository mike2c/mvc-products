using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class InvoiceController : Controller
    {
        private ProductsEntities db = new ProductsEntities();
        // GET: Orders
        public ActionResult Index()
        {

            return View(db.Invoice.ToList()); ;
        }

        public ActionResult New()
        {

            return View();
        }

        public ActionResult LoadPartialViewDynamically()
        {
            ViewBag.ProductList = db.Product; // new SelectList(db.Product, "ProductId", "ProductDescripcion");

            return View("NewItemPartialView");
        }
    }
}