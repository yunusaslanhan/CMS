using CMSProject.Business.Context;
using CMSProject.Business.Services;
using CMSProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CMSProject.XUnitTest
{
	public class MainPageTest
	{
		public CMSContext dbContext;
		public MainPageTest()
		{
			var options = new DbContextOptionsBuilder<CMSContext>()
				.UseInMemoryDatabase(databaseName: "fake_db")
				.Options;

			dbContext = new CMSContext(options);
			

			dbContext.MainPages.Add(new MainPage
			{
				Name = "Spor",
				ParentId = 0,
				CreateDate = DateTime.Now
			});
			
		}

		[Fact]
		public void GetPostTest()
		{
			var mainPageServices = new MainPageServices(dbContext);
			var x = mainPageServices.GetMainPageList();

			Assert.NotNull(x);
		}

		[Fact]
		public void AddMainPageTest()
		{
			var postServices = new MainPageServices(dbContext);
			postServices.AddPage(1,"Hasar");


			var x = dbContext.MainPages.ToList();

			Assert.Equal(2, x.Count());
		}


		[Fact]
		public void GetGenerateMenuTest()
		{
			var mainPageServices = new MainPageServices(dbContext);
			var x = mainPageServices.GenerateMenuUi();

			Assert.NotNull(x);
		}


	}

}

