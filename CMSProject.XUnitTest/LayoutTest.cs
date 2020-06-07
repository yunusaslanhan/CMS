using CMSProject.Business.Context;
using CMSProject.Business.Services;
using CMSProject.Common.Dtos;
using CMSProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CMSProject.XUnitTest

{
	public class LayoutTest
	{
		public CMSContext dbContext;
		public LayoutTest()
		{
			var options = new DbContextOptionsBuilder<CMSContext>()
				.UseInMemoryDatabase(databaseName: "fake_db")
				.Options;

			dbContext = new CMSContext(options);
			dbContext.Layouts.Add(new Layout
			{
				Name = "layout99",
				CreateDate = DateTime.Now
				
			});


			dbContext.LayoutComponents.Add(new LayoutComponent
			{
			
				Size = "6",
				Name = "Sol Alt Resim",
				CreateTime = DateTime.Now,
				ComponentClass = "<div>abc</div>"

			});


			dbContext.SaveChanges();


		}

		//[Fact]
		//public void AddLayoutTest()
		//{

		//	LayoutDto layoutDtoTest = new LayoutDto();

		
		//	layoutDtoTest.CreateDate = DateTime.Now;
		//	layoutDtoTest.Name = "layout100";

			
		//	layoutDtoTest.layoutComponentDtos.Add(new LayoutComponentDto {

			
		//		LayoutId = 1,
		//		Size = "8",
		//		Name = "Sağ Alt Resim",
		//		CreateTime = DateTime.Now,
		//		ComponentClass = "<div>123123</div>"

		//	});



		//	var service = new LayoutService(dbContext);
		//	service.SaveLayout(layoutDtoTest);
			
		//	var x = dbContext.Layouts.ToList();
		//	Assert.Equal(2, x.Count());


		//}



		[Fact]
		public void ListLayoutTest()
		{
			var layoutService = new LayoutService(dbContext);
			var x = layoutService.GetLayoutList();

			Assert.NotNull(x);
		}

		[Fact]
		public void ListLayoutComponentTest()
		{
			var service = new LayoutService(dbContext);
			var y = service.GetLayoutComponentList(1);

			Assert.NotNull(y);
		}



	}
}