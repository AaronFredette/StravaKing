using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Data.DataModels.Users
{
	public class User
	{
		public long Id { get; set; }
		public string Email { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
	}
}
