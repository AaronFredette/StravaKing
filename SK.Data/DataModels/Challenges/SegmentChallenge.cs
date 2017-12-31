using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK.Data.DataModels.Strava;

namespace SK.Data.DataModels.Challenges
{
    public class SegmentChallenge
    {
        //[Key]
        //[Column(Order = 0)]
        //[ForeignKey("Challenge")]
        public long ChallengeId { get; set; }

        public virtual Challenge Challenge { get; set; }

        public long SegmentId { get; set; }

        public virtual StravaSegment Segment { get; set; }
    }
}
