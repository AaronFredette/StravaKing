using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SK.Library.Enums;
using SK.Data.DataModels.Challenges;
using SK.Library.Classes.Models.Users;
using SK.Library.Classes.Session;

namespace SK.Library.Classes.Models.Challenges
{
	public class ChallengeViewModel
	{
		public ChallengeViewModel()
		{
			ChallengerEmail = Currentuser.AthleteEmail;
		}

		public ChallengeViewModel(Challenge challengeData) {
			ChallengerEmail = challengeData.ChallengerEmail;
			ChallengeeEmail = challengeData.ChallengeeEmail;
			ChallengeStatus = (ChallengeStatus)challengeData.ChallengeStatus;
			ChallengeType = (ChallengeType)challengeData.ChallengeType;
			StartTime = challengeData.StartTime;
			EndTime = challengeData.EndTime;
			Wager = Wager;
		}
		
		public string ChallengerEmail{get; private set; }
		public string ChallengeeEmail { get; set; }
		public ChallengeType ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }

		public string ErrorMessage { get; set; }
		public bool HasError { get; private set; }

		public void SetError(string errorMessage)
		{
			ErrorMessage = errorMessage;
			HasError = true;
		}

		public ChallengeStatus ChallengeStatus { get; set; }

		public UserViewModel Currentuser
		{
			get { return SessionManager.GetCurrentUser(); }
		}
		public Challenge ToChallengeDataModel()
		{
			return new Challenge
			{
				ChallengerEmail = ChallengerEmail,
				ChallengeeEmail = ChallengeeEmail,
				ChallengeType = (int)ChallengeType,
				ChallengeStatus = (int)ChallengeStatus,
				StartTime = StartTime,
				EndTime = EndTime,
				Wager = Wager
			};
		}
	}
}