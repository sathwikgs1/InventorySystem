using InventorySystemExample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystemExample.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [AdminAuthorization]
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}