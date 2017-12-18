using SK.Library.Classes.Session;
using System.Web.Mvc;
using System.Web.Routing;
namespace StravaKing.Authentication.Filters
{
	public class EnsureSessionFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (SessionManager.GetCurrentUser() == null)
			{
				filterContext.Result = new RedirectToRouteResult(
			   new RouteValueDictionary
			   {
					{ "controller", "Authentication" },
					{ "action", "Logout" }
			   });
			}
		
		}
	}
}
