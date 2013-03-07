using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSH.Intranet.Web.Areas.ErrorHandler.Controllers
{
    public class ErrorHomeController : Controller
    {
        //
        // GET: /ErrorHandler/ErrorHome/

        public ActionResult Index()
        {
            int i = 1; //sendmail give url
            return View();
        }

    }
}
