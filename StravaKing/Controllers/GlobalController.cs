using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SK.Library.Classes.Session;

namespace StravaKing.Controllers
{
    public class GlobalController : Controller
    {
		// GET: Global
		[ChildActionOnly]
		public ActionResult Footer()
        {
            return PartialView("~/Views/Shared/_Footer.cshtml",SessionManager.GetCurrentUser());
        }
    }
}