using System;
using System.Collections.Generic;
using System.Linq;
using StravaKing.Authentication.Filters;
using System.Web.Mvc;
using SK.Library.Enums;
using SK.Library.Classes.Models.Challenges;
using SK.Library.Classes.Helpers.Challenges;

namespace StravaKing.Controllers
{
	[EnsureSessionFilter]
    public class ChallengeController : Controller
    {
        // GET: Challenge
        public ActionResult CreateChallenge()
        {
            return View(new NewChallengeViewModel());
        }

		private ChallengeManager _challengeManager;
		private ChallengeManager Manager
		{
			get
			{
				if (_challengeManager == null)
				{
					_challengeManager = new ChallengeManager();
				}
				return _challengeManager;
			}
		}
	    [HttpPost]
	    public ActionResult CreateChallenge(NewChallengeViewModel model)
	    {
		    model.ChallengeStatus = ChallengeStatus.Proposed;
						
			Manager.CreateChallenge(model);

			return View(model);
	    }

		[HttpGet]
		public ActionResult MyChallenges()
		{
			return View(Manager.GetChallengesForCurrentUser().ToList());
		}
    }
}