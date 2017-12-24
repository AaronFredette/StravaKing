//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using SK.Data.DataModels.Users;
namespace SK.Data.DataModels.Challenges
{
	public class ChallengeParticipant
	{
		//[Key]
		//[Column(Order = 0)]
		//[ForeignKey("User")]
		public long UserId { get; set; }

		//[Key]
		//[Column(Order = 0)]
		//[ForeignKey("Challenge")]
		public long ChallengeId { get; set; }

		public virtual Challenge Challenge { get; set; }
		public virtual User User { get; set; }
	}
}
