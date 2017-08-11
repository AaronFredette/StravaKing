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
		public UserViewModel(Athlete athlete)
		{
			AthleteEmail = athlete.Email;
			AthleteName = string.Format("{0} {1}", athlete.FirstName, athlete.LastName);
		}
		public string AthleteName { get; set; }
		public string AthleteEmail { get; set; }
	}
}
