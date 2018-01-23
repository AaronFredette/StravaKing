using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Org.BouncyCastle.Asn1.Ocsp;
using SK.Library.Configuration;
using SK.StravaLibrary;

namespace SK.Library.Classes.Helpers.Authentication
{
	public class AuthenticationManager
	{
		public Authenticator CreateAuthenticator(HttpRequestBase request)
		{
			var redirectUrl = string.Format("{0}://{1}:{2}/Home/Callback", request.Url.Scheme, request.Url.Host, request.Url.Port);

			var config = new RestSharp.Portable.OAuth2.Configuration.RuntimeClientConfiguration
			{
				IsEnabled = false,
				ClientId = AppConfigStrava.StravaClientId,
				ClientSecret = AppConfigStrava.StravaClientSecret,
				RedirectUri = redirectUrl,
				Scope = "write,view_private",
			};
			var client = new StravaClient(new Authentication.RequestFactory(), config);

			return new Authenticator(client);
		}
	}
}