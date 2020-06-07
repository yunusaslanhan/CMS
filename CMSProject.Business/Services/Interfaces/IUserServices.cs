using CMSProject.Common.Dtos;
using CMSProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Business.Services.Interfaces
{
	public interface IUserServices
	{
		bool LoginControl(string email, string password);
		UserDto GetByUserEmail(string email);
		User GetUser(string email);

	}
}
