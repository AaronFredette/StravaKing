using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Data.DataModels.Challenges
{
	public class Challenge
	{
		public string ChallengerEmail { get; set; }
		public string ChallengeeEmail { get; set; }
		public int ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }
		public int ChallengeStatus { get; set; }
	}
}
