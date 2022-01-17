using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventorySystemExample.Filters;
using InventorySystemExample.Identity;

namespace InventorySystemExample.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        [AdminAuthorization]
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<ApplicationUser> existingUsers = db.Users.ToList();
            return View(existingUsers);
        }
    }
}