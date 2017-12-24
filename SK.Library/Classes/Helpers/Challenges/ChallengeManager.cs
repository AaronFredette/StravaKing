using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SK.Library.Classes.Models.Challenges;
using SK.Library.Classes.Session;
using SK.Data.Accessors.Challenges;

namespace SK.Library.Classes.Helpers.Challenges
{
	public class ChallengeManager
	{
		private ChallengeAccessor _challengeAccess;
		private ChallengeAccessor ChallengeAccess
		{
			get
			{
				if (_challengeAccess==null)
				{
					_challengeAccess = new ChallengeAccessor();
				}
				return _challengeAccess;
			}
		}

		public IEnumerable<ChallengeViewModel> GetChallengesForCurrentUser()
		{
			var currentUser = SessionManager.GetCurrentUser();

			return ChallengeAccess.GetChellengesForUser(currentUser.AthleteEmail).Select(x => new ChallengeViewModel(x));
		}

		public NewChallengeViewModel CreateChallenge(NewChallengeViewModel newChallenge)
		{
			//TODO: 
			// Add another table of emails to sync accounts for
			// we may need to do this when we sync someones friends 
			try {
				var participantIds = new List<long>();
				participantIds.Add(newChallenge.ChallengeeUserId);
				participantIds.Add(SessionManager.GetCurrentUser().UserId);
				if (ChallengeAccess.CreateChallenge(newChallenge.ToChallengeDataModel()))
				{
					return newChallenge;
				}
			}catch(Exception e)
			{
				newChallenge.SetError("An error occured when trying to create your challenge.");
			}
			
			return newChallenge;
		}
	}
}