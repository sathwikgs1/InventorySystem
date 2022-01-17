using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventorySystemExample.Filters;
using Company.DomainModels;
using Company.DataLayer;
using Company.ServiceContracts;
using Company.ServiceLayer;

namespace InventorySystemExample.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class InventoriesController : Controller
    {
        CompanyDbContext db;
        IInventoriesService invenService;

        public InventoriesController(IInventoriesService iService)
        {
            this.db = new CompanyDbContext();
            this.invenService = iService;
        }
        public ActionResult Index()
        {
            List<Inventory> inventories = invenService.GetProducts();
            return View(inventories);
        }

        public ActionResult Details(long id)
        {
            Inventory I = invenService.GetProductByProductID(id);
            return View(I);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ProductID, ProductName, Price, AvailabilityStatus,")] Inventory I)
        {
            if (ModelState.IsValid)
            {
                db.Inventories.Add(I);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(long id)
        {
            Inventory existingProduct = invenService.GetProductByProductID(id);
            return View(existingProduct);
        }

        [HttpPost]
        public ActionResult Edit(Inventory I)
        {
            if (ModelState.IsValid)
            {
                invenService.UpdateProduct(I);
            }
            return RedirectToAction("Index", "Inventories");
        }

        public ActionResult Delete(long id)
        {
            Inventory existingProduct = db.Inventories.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(existingProduct);
        }

        [HttpPost]
        public ActionResult Delete(long id, Inventory I)
        {
            Inventory existingProduct = db.Inventories.Where(temp => temp.ProductID == id).FirstOrDefault();
            db.Inventories.Remove(existingProduct);
            db.SaveChanges();
            return RedirectToAction("Index", "Inventories");
        }
    }
}