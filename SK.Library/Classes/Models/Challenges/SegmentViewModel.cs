using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Library.Classes.Models.Challenges
{
    public class SegmentViewModel
    {
        public long SegmentId { get; set; }
        public string SegmentName { get; set; }
        public float SegmentDistance { get; set; }
        public string SegmentPolyLine { get; set; }
        public AthleteSegmentViewModel CurrentUserSegmentData { get; set; }
        public AthleteSegmentViewModel OpponentSegmentData { get; set; }
    }
}
