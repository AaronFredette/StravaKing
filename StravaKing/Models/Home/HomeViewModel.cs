using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SK.Library.Configuration;
using SK.Library.Constants;

namespace StravaKing.Models.Home
{
	public class HomeViewModel
	{
		public string StravaLoginUrl
		{
			
			get { return string.Format("{0}?client_id={1}&response_type=code&redirect_uri={2}&approval_prompt=auto", StravaConstants.StravaLoginRootUrl,AppConfigStrava.StravaClientId,AppConfigSK.StravaRedirectUri); }
		}

		public string AthleteName { get; set; }
	}
}