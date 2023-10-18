using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApptSoft.Controllers
{
    //[Authorize]
    public class DashBoardController : Controller
    {
        // GET: DashBoard
       
        public ActionResult DashBoardIndex()
        {
            return View();
        }
    }
}