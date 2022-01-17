using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventorySystemExample.Filters;
using Company.DataLayer;
using Company.DomainModels;
using Company.ServiceContracts;
using Company.ServiceLayer;

namespace InventorySystemExample.Controllers
{
    public class InventoriesController : Controller
    {
        CompanyDbContext db;
        IInventoriesService invenService;

        public InventoriesController(IInventoriesService iService)
        {
            this.db = new CompanyDbContext();
            this.invenService = iService;
        }
        // GET: Inventories
        [MyAuthenticationFilter]
        [EmployeeAuthorization]
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
    }
}