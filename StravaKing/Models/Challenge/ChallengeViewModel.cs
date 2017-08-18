using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SK.Library.Classes.Models.Users;
using SK.Library.Classes.Session;
using SK.Library.Enums;

namespace StravaKing.Models.Challenge
{
	public class ChallengeViewModel
	{
		public string ChallengerEmail { get; set; }
		public string ChallengeeEmail { get; set; }
		public ChallengeType ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }

		public ChallengeStatus ChallengeStatus { get; set; }

		public UserViewModel Currentuser
		{
			get { return SessionManager.GetCurrentUser(); }
		}
	}
}