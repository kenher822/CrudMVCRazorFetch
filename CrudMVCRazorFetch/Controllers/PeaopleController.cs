using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVCRazorFetch.Controllers
{
    public class PeaopleController : Controller
    {
        // GET: Peaople
        public ActionResult Index()
        {
            return View();
        }
    }
}