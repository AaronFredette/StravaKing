using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SK.Library.Classes.Session;
using StravaKing.Authentication;
namespace StravaKing.Controllers
{
    public class AuthenticationController : Controller
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
		// GET: Authentication
		public async Task<ActionResult> Callback()
		{
			var authenticator = AuthManager.CreateAuthenticator(Request);
			await authenticator.OnPageLoaded(Request.Url);
			return RedirectToAction("Index","Home");
		}

	    public ActionResult Logout()
	    {
			var authenticator = AuthManager.CreateAuthenticator(Request);
		    authenticator.AccessToken = null;
		    SessionManager.UpdateCurrentUser(null);
			return RedirectToAction("Index", "Home");
	    }
	}
}