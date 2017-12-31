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
		public string ChallengeName { get; set; }
		public IEnumerable<UserViewModel> Opponents { get; set; }
		public ChallengeType ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }
        public UserViewModel CurrentLeader { get; set; }
        
        //Used for time in saddle challenges
        public TimeSpan TargetTimeInSaddle { get; set; }

        //Used in total distance challenges 
        public float TargetDistance { get; set; }

        //used in segment challenges 
        public SegmentViewModel SegmentData { get; set; }

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
	}
}