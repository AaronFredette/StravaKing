using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
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
	}
}