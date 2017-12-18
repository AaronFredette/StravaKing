using System;
using System.Collections.Generic;
using System.Linq;
using StravaKing.Authentication.Filters;
using System.Web.Mvc;
using SK.Library.Enums;
using StravaKing.Models.Challenge;

namespace StravaKing.Controllers
{
	[EnsureSessionFilter]
    public class ChallengeController : Controller
    {
        // GET: Challenge
        public ActionResult CreateChallenge()
        {
            return View(new ChallengeViewModel());
        }

	    [HttpPost]
	    public ActionResult CreateChallenge(ChallengeViewModel model)
	    {
		    model.ChallengeStatus = ChallengeStatus.Proposed;
			return View(model);
	    }
    }
}