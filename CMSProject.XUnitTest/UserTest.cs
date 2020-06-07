using CMSProject.Business.Context;
using CMSProject.Business.Services;
using CMSProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CMSProject.XUnitTest
{
	public class UserTest
	{

		public CMSContext dbContext;
		public UserTest()
		{
			var options = new DbContextOptionsBuilder<CMSContext>()
				.UseInMemoryDatabase(databaseName: "fake_db")
				.Options;

			dbContext = new CMSContext(options);
			var x=dbContext.Users.Add(new User
			{
				
				UserName = "yunus",
				Email = "yunus@gmail.com",
				Password = "123",
				Photo = "",
				RoleId=1

			});


			dbContext.SaveChanges();


		}


		[Fact]
		public void GetUserTest()
		{
			var userServices = new UserServices(dbContext);
			var x = userServices.GetUser("yunus@gmail.com");

			Assert.NotNull(x);
		}



		[Fact]
		public void GetUserByEmailTest()
		{
			var userServices = new UserServices(dbContext);
			var y = userServices.GetByUserEmail("yunus@gmail.com");

			Assert.NotNull(y);
		}

		[Fact]
		public void LoginTest()
		{
			var userServices = new UserServices(dbContext);
			var z = userServices.LoginControl("yunus@gmail.com","123");

			Assert.True(z);
		}



	}
}
