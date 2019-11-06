using CrudMVCRazorFetch.Models;
using CrudMVCRazorFetch.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVCRazorFetch.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Peaople
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<ListPeopleViewModel> lst = new List<ListPeopleViewModel>();
            using (CrudMVCRazorFetchEntities db = new CrudMVCRazorFetchEntities())
            {
                lst =
                    (from d in db.People
                     orderby d.id descending
                     select new ListPeopleViewModel
                     {
                         Id = d.id,
                         Name = d.name,
                         Age = d.age
                     }).ToList();
            }
            return View(lst);
        }
    }
}