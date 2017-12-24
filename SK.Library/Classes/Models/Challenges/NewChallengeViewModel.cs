using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SK.Library.Enums;
using SK.Data.DataModels.Challenges;
using SK.Library.Classes.Models.Users;
using SK.Data.DataModels.Users;
using SK.Library.Classes.Session;

namespace SK.Library.Classes.Models.Challenges
{
	public class NewChallengeViewModel
	{
		public string ChallengeeEmail { get; set; }
		public long ChallengeeUserId { get; set; }

		public ChallengeType ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }
		public string ErrorMessage { get; set; }
		public bool HasError { get; private set; }
		public ChallengeStatus ChallengeStatus { get; set; }

		public void SetError(string errorMessage)
		{
			ErrorMessage = errorMessage;
			HasError = true;
		}
		public UserViewModel CurrentUser
		{
			get { return SessionManager.GetCurrentUser(); }
		}
		public Challenge ToChallengeDataModel()
		{
			return new Challenge
			{
				ChallengeType = (int)ChallengeType,
				ChallengeStatus = (int)ChallengeStatus,
				StartTime = StartTime,
				EndTime = EndTime,
				Wager = Wager
			};
		}
	}
}
