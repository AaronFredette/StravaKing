using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using SK.Library.Classes.Models.Users;

namespace SK.Library.Classes.Session
{
	public static class SessionManager
	{
		private static readonly string _currentUserKey = "sessionmanager_currentuser";

		public static UserViewModel GetCurrentUser()
		{
			return HttpContext.Current.Session[_currentUserKey] as UserViewModel;

		}

		public static void UpdateCurrentUser(UserViewModel model)
		{
			HttpContext.Current.Session[_currentUserKey] = model;
		}
	}
}
