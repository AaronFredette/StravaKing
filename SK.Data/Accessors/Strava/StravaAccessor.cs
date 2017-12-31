using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK.Data.DataModels.Strava;
namespace SK.Data.Accessors.Strava
{
    public class StravaAccessor
    {
        public StravaSegment GetStravaSegment(long segmentId)
        {
            //segment request url https://www.strava.com/api/v3/segment_efforts/29306400458
            return new StravaSegment
            {
                SegmentId = 29306400458,
                Name = "Lake trail",
                Distance = 78
            };
        }
    }
}
