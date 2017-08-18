using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StravaSharp;

namespace SK.Library.Classes.Models.Users
{
	public class UserViewModel
	{
		public UserViewModel(Athlete athlete, IEnumerable<Athlete> friends = null)
		{
			
			AthleteEmail = athlete.Email;
			AthleteName = string.Format("{0} {1}", athlete.FirstName, athlete.LastName);
			AthleteImage = athlete.ProfileMedium;

			Friends = friends == null ? new List<UserViewModel>(): friends.Select(x => new UserViewModel(x)).ToList();
			
		}
		public string AthleteName { get; set; }
		public string AthleteEmail { get; set; }
		public string AthleteImage { get; set; }
		public List<UserViewModel> Friends { get; set; }  
	}
}
