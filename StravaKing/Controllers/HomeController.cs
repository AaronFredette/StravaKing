using RestSharp.Portable.OAuth2;
using StravaSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SK.Library;
using SK.Library.Configuration;
using StravaKing.Authentication;
using StravaKing.Models.Home;


namespace StravaKing.Controllers
{
    public class HomeController : Controller
    {
	    private AuthenticationManager _authManager;
	    AuthenticationManager AuthManager
	    {
		    get
		    {
			    if (_authManager == null)
			    {
				    _authManager=new AuthenticationManager();
			    }   
				return _authManager;
		    }
	    }
		// GET: Home
		public async Task<ActionResult> Index()
		{
			var authenticator =AuthManager.CreateAuthenticator(Request);
			var viewModel = new HomeViewModel();
			if (authenticator.IsAuthenticated)
			{
				
				var client = new StravaSharp.Client(authenticator);
				var athlete = await client.Athletes.GetCurrent();
				viewModel.AthleteName = string.Format("{0} {1}", athlete.FirstName, athlete.LastName);
				return View(viewModel);
			}

			return View("Login", viewModel);

		}
	}
}