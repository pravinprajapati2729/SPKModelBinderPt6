using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPKModelBinderPt6.Models;

namespace SPKModelBinderPt6.Controllers
{
   
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Enter()
        {
            return View("EnterDetails");
            //GithubTesting
        }

        public ActionResult submit([ModelBinder(typeof(CustomerBinding))]Customer obj)
        {
            return View("Load",obj);
        }
    }
}