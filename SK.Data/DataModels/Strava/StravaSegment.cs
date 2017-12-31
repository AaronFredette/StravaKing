using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Data.DataModels.Strava
{
    public class StravaSegment
    {
        public long SegmentId { get; set; }
        public float Distance { get; set; }
        public string Name { get; set; }
        public string MapId { get; set; }
        public string PolyLine { get; set; }
        public int ResourceState { get; set; }
    }
}
