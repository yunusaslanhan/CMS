using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class UserDto
	{
		public int UserId { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }

		public string Email { get; set; }

		public int RoleId { get; set; }

		public string Photo { get; set; }	

	}
}
