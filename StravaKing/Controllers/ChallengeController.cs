using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StravaKing.Authentication.Filters;
using System.Web.Mvc;
using SK.Library.Enums;
using SK.Library.Classes.Models.Challenges;
using SK.Library.Classes.Helpers.Challenges;
using SK.Library.Classes.Models.Users;
using SK.Library.Classes.Session;
using SK.Library.Configuration;
using SK.Library.Classes.Helpers.Authentication;
using StravaKing.Models.Home;
using RestSharp.Portable.HttpClient;

namespace StravaKing.Controllers
{
	[EnsureSessionFilter]
    public class ChallengeController : Controller
    {
        private AuthenticationManager _authManager;
        AuthenticationManager AuthManager
        {
            get
            {
                if (_authManager == null)
                {
                    _authManager = new AuthenticationManager();
                }
                return _authManager;
            }
        }
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

        [HttpGet]
        public async Task<string> TestAuth()
        {
            var authenticator = AuthManager.CreateAuthenticator(Request);
            var viewModel = new HomeViewModel();
            if (authenticator.IsAuthenticated)
            {
                //RestClient.
                var client = new StravaSharp.Client(authenticator);
                var activities = await client.Activities.GetAthleteActivitiesAfter(DateTime.Now.AddMonths(-4));
                
                //var athlete = await client.Segments.Get
                
                //SessionManager.UpdateCurrentUser(new UserViewModel(athlete, friends));

                return "test";
            }

            return "fail";
        }

    }
}