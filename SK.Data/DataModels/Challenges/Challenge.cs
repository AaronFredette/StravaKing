using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK.Data.DataModels.Users;

namespace SK.Data.DataModels.Challenges
{
	public class Challenge
	{
		public long ChallengeId { get; set; }
		public virtual ICollection<ChallengeParticipant> Participants{get;set;}
		public virtual User Challenger { get; set; }
		public int ChallengeType { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Wager { get; set; }
		public int ChallengeStatus { get; set; }
	}
}
