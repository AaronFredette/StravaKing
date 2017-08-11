using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SK.Library.Enums;

namespace SK.Library.Classes.Models.Challenges
{
	public class ChallengeViewModel
	{
		public string ChallengerEmail { get; set; }
		public string ChallengeeEmail { get; set; }
		public ChallengeType ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }
	}
}