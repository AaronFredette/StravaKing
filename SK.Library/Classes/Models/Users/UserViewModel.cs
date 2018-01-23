using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SK.StravaLibrary;
using SK.Data.DataModels.Users;

namespace SK.Library.Classes.Models.Users
{
	public class UserViewModel
	{
		public UserViewModel(Athlete athlete, IEnumerable<Athlete> friends = null)
		{
			//TODO: 
			//Get rid of this and only have one path to this model
			//via the data layer, add getUserByEmail to return user then populate 
			//this model
			AthleteEmail = athlete.Email;
			AthleteName = string.Format("{0} {1}", athlete.FirstName, athlete.LastName);
			AthleteImage = athlete.ProfileMedium;
			UserId = 2;
			Friends = friends == null ? new List<UserViewModel>(): friends.Select(x => new UserViewModel(x)).ToList();
		}

		public UserViewModel(User user)
		{
			AthleteEmail = user.Email;
			AthleteName = user.Name;
			AthleteImage = user.ImageUrl;
			UserId = user.Id;
		}
		public long UserId { get; set; }
		public string AthleteName { get; set; }
		public string AthleteEmail { get; set; }
		public string AthleteImage { get; set; }
		public List<UserViewModel> Friends { get; set; }  
	}
}
