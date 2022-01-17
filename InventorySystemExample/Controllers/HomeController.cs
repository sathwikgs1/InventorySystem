using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystemExample.Controllers
{
    public class HomeController : Controller
    {
        
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            return View();
        }  
    }
}