using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SK.Library.Enums;
using SK.Library.Classes.Models.Challenges;
using SK.Library.Classes.Session;
using SK.Library.Classes.Models.Users;
using SK.Data.Accessors.Challenges;
using SK.Data.Accessors.Strava;
using SK.Data.DataModels.Challenges;

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

        private StravaAccessor _stravaDataAccess;
        private StravaAccessor StravaDataAccess
        {
            get
            {
                if (_stravaDataAccess == null)
                {
                    _stravaDataAccess = new StravaAccessor();
                }
                return _stravaDataAccess;
            }
        }

		public IEnumerable<ChallengeViewModel> GetChallengesForCurrentUser()
		{
			var currentUser = SessionManager.GetCurrentUser();
            List<ChallengeViewModel> challenges = new List<ChallengeViewModel>();

            foreach (Challenge challengeData in ChallengeAccess.GetChallengesForUser(currentUser.AthleteEmail)) {
                challenges.Add(CreateChallengeViewModel(challengeData));
            }

            return challenges;
		}

        private ChallengeViewModel CreateChallengeViewModel(Challenge challengeData) { 
            var currentUser = SessionManager.GetCurrentUser();
              var challengeViewModel = new ChallengeViewModel()
                {
                    Opponents = challengeData.Participants
                            .Where(x => !string.Equals(x.User.Email, currentUser.AthleteEmail, StringComparison.OrdinalIgnoreCase))
                            .Select(p => new UserViewModel(p.User)).ToList(),

                    ChallengeStatus = (ChallengeStatus)challengeData.ChallengeStatus,
                    ChallengeType = (ChallengeType)challengeData.ChallengeType,
                    StartTime = challengeData.StartTime,
                    EndTime = challengeData.EndTime,
                    Wager = challengeData.Wager,
                };

              if ((ChallengeType)challengeData.ChallengeType == ChallengeType.SegementTime)
              {
                  long segmentId;
                  if (long.TryParse(challengeData.ChallengeObjective, out segmentId))
                  {
                      challengeViewModel.SegmentData = CreateSegmentViewModel(segmentId);
                  }
              }

            return challengeViewModel;
        }

        private SegmentViewModel CreateSegmentViewModel(long segmentId)
        {
           var stravaSegment = StravaDataAccess.GetStravaSegment(segmentId);

           return new SegmentViewModel()
           {
               SegmentName = stravaSegment.Name,
               SegmentId = stravaSegment.SegmentId,
               SegmentDistance = stravaSegment.Distance,
               SegmentPolyLine = stravaSegment.PolyLine,
               //TODO : populate database and get user data for these fields
               //CurrentUserSegmentData = 
           };
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