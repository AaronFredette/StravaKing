using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK.Data.DataModels.Challenges;

namespace SK.Data.Accessors.Challenges
{
	public class ChallengeAccessor
	{
		public bool CreateChallenge(Challenge newChallenge)
		{
			return true;
		}


		#region GetChallenges
		public List<Challenge> GetChellengesForUser(string email)
		{
			return new List<Challenge>()
			{
				new Challenge() {
					ChallengeeEmail = "atreat@gmail.com",
					ChallengeType = 2,
					EndTime = DateTime.Now.AddDays(2),
					StartTime = DateTime.Now,
					Wager = "bragging rights",
					ChallengerEmail = "afredett@gmail.com",
					ChallengeStatus = 3

				},
					new Challenge() {
					ChallengeeEmail = "atreat@gmail.com",
					ChallengeType = 3,
					EndTime = DateTime.Now.AddDays(2),
					StartTime = DateTime.Now,
					Wager = "bragging rights",
					ChallengerEmail = "afredett@gmail.com",
					ChallengeStatus = 2

				},
				
            };
		}
		#endregion
	}
}
