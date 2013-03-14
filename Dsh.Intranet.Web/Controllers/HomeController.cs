using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dsh.Intranet.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult FaqTemplate()
        {
            return View();
        }

        public ActionResult FormTemplate()
        {
            return View(); 
        }

        public ActionResult RightSideBarTemplate()
        {
            return View();
        }
        public ActionResult TwoColTemplate()
        {
            return View(); 
        }
     
    }
}
