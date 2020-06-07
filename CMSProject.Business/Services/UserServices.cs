using CMSProject.Business.Context;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Common.Dtos;
using CMSProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSProject.Business.Services
{
	public class UserServices:IUserServices
	{
		private CMSContext _dbContext;

		public UserServices(CMSContext dbContext)
		{
			_dbContext = dbContext;
		}



		public UserDto GetByUserEmail(string email)
		{
			var user = GetUser(email);
			return new UserDto
			{
				UserId = user.UserId,
				UserName=user.UserName,
				Email = user.Email,
				Password = user.Password,
				RoleId=user.RoleId,
				Photo = user.Photo

			};


		}

		public User GetUser(string email)
		{
			var model = _dbContext.Users.Where(x => x.Email == email).FirstOrDefault();
			return model;

		}


		public bool LoginControl(string email, string password)
		{

			var indexUserNamePassword = _dbContext.Users.Any(x => x.Email == email && x.Password == password);


			if (indexUserNamePassword)
			{
				return true;
			}

			else
			{
				return false;
			}

		}

	}
}
