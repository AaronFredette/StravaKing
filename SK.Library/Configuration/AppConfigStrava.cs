using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using RestSharp.Portable.OAuth2.Configuration;

namespace SK.Library.Configuration
{
	public static class AppConfigStrava
	{
		#region Strava Tokens

		public static string StravaClientSecret {get { return ConfigurationManager.AppSettings["Strava.ClientSecret"]; } }
		public static string StravaClientId { get { return ConfigurationManager.AppSettings["Strava.ClientId"]; } }
		public static string StravaPublicToken { get { return ConfigurationManager.AppSettings["Strava.PublicToken"]; } }

		#endregion
	}
}
