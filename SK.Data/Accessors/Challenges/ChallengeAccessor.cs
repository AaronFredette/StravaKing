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
		public List<Challenge> GetChallengesForUser(string email)
		{
			return new List<Challenge>()
			{
				new Challenge() {
					Participants = new List<ChallengeParticipant>() {
						new ChallengeParticipant()
						{
							User = new DataModels.Users.User
							{
								Email = "atreat@no.com",
								Name="Austin Emmonds",
								ImageUrl = "https://dgalywyr863hv.cloudfront.net/pictures/athletes/10469057/4005334/3/medium.jpg"
							},
							Challenge = new Challenge()
							{
								
							}
						},
						new ChallengeParticipant()
						{
							User= new DataModels.Users.User {
							Email="afredett@gmail.com",
							Name = "Aaron Fredette",
							ImageUrl = "https://dgalywyr863hv.cloudfront.net/pictures/athletes/10469057/4005334/3/medium.jpg"
							},
							Challenge = new Challenge()
							{

							}
						}
					},
					ChallengeType = 2,
					EndTime = DateTime.Now.AddDays(2),
					StartTime = DateTime.Now,
					Wager = "bragging rights",
					Challenger = new DataModels.Users.User()
					{
						Email="aaron@test.com"
					},
					ChallengeStatus = 3

				},
					new Challenge() {
					Participants =  new List<ChallengeParticipant>() {
						new ChallengeParticipant()
						{
							User = new DataModels.Users.User
							{
								Email = "atreat@no.com",
								Name="Austin Emmonds",
								ImageUrl = "https://dgalywyr863hv.cloudfront.net/pictures/athletes/10469057/4005334/3/medium.jpg"
							},
							Challenge = new Challenge()
							{

							}
						},
						new ChallengeParticipant()
						{
							User= new DataModels.Users.User {
							Email="afredett@gmail.com",
							Name = "Aaron Fredette",
							ImageUrl = "https://dgalywyr863hv.cloudfront.net/pictures/athletes/10469057/4005334/3/medium.jpg"
							},
							Challenge = new Challenge()
							{

							}
						}
					},
					ChallengeType = 3,
					EndTime = DateTime.Now.AddDays(2),
					StartTime = DateTime.Now,
					Wager = "bragging rights",
					Challenger = new DataModels.Users.User()
					{
						Email="aaron@test.com"
					},
					ChallengeStatus = 2

				},
				
            };
		}
		#endregion
	}
}
