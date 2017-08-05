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
using SK.Library.Constants;
using StravaKing.Authentication;
using StravaKing.Models.Home;


namespace StravaKing.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		public async Task<ActionResult> Index()
		{
			var authenticator = CreateAuthenticator();
			var viewModel = new HomeViewModel();
			if (authenticator.IsAuthenticated)
			{
				//var client = new StravaSharp.Client(authenticator);
				//var activities = await client.Activities.GetAthleteActivities();
				//foreach (var activity in activities)
				//{
				//	viewModel.Activities.Add(new ActivityViewModel(activity));
				//}
			}
			return View(viewModel);
		}

		Authenticator CreateAuthenticator()
		{
			var redirectUrl = string.Format("{0}://{1}:{2}/Home/Callback", Request.Url.Scheme, Request.Url.Host, Request.Url.Port);
			
			var config = new RestSharp.Portable.OAuth2.Configuration.RuntimeClientConfiguration
			{
				IsEnabled = false,
				ClientId = AppConfigStravaConstants.StravaClientId,
				ClientSecret = AppConfigStravaConstants.StravaClientSecret,
				RedirectUri = redirectUrl,
				Scope = "write,view_private",
			};
			var client = new StravaClient(new Authentication.RequestFactory(), config);

			return new Authenticator(client);
		}

	}
}