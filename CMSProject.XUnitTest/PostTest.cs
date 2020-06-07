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
	public class PostTest
	{

		public CMSContext dbContext;
		public PostTest()
		{
			var options = new DbContextOptionsBuilder<CMSContext>()
				.UseInMemoryDatabase(databaseName: "fake_db")
				.Options;

			dbContext = new CMSContext(options);
			dbContext.Posts.Add(new Post
			{

				LayoutId = 1,
				UserId = 3,
				PostTitle = "FENERBAHÇE",
				CreateDate = DateTime.Now,
				SubCategoryId = 1,
				PostDesc ="Fenerbahçe baskette dünya birincisi",
				PostPhoto ="",
				MainPageId = 3

			});

			dbContext.Posts.Add(new Post
			{

				LayoutId = 1,
				UserId = 3,
				PostTitle = "MALATYASPOR",
				CreateDate = DateTime.Now,
				SubCategoryId = 1,
				PostDesc = "Malatya ligde 3. sırada",
				PostPhoto = "",
				MainPageId = 3

			});


			dbContext.PostDetails.Add(new PostDetail
			{
				PostId = 1,
				PostHtml = "<html></html>",
				CreateDate = DateTime.Now

			});

			dbContext.PostDetails.Add(new PostDetail
			{
				PostId = 2,
				PostHtml = "<html><body></body></html>",
				CreateDate = DateTime.Now

			});



			dbContext.PostImages.Add(new PostImage
			{

				PostId = 1,
				Desc = "Açıklama",
				Image = "Resim"

			});

			dbContext.SaveChanges();


		}
		[Fact]
		public void GetPostTest()
		{
			var postServices = new PostServices(dbContext);
			var x = postServices.GetPostList();

			Assert.NotNull(x);
		}

		[Fact]
		public void GetPostByIdTest()
		{
			var postServices = new PostServices(dbContext);
			var x = postServices.GetPostById(1);

			Assert.NotNull(x);
		}


		[Fact]
		public void GetPostDetailTest()
		{
			var postServices = new PostServices(dbContext);
			var x = postServices.GetPostDetailList(1);

			Assert.NotNull(x);
		}

		[Fact]
		public void GetMainPagePostTest()
		{
			var postServices = new PostServices(dbContext);
			var x = postServices.GetMainPagePostList(1);

			Assert.NotNull(x);
		}


		[Fact]
		public void GetSliderTest()
		{
			var postServices = new PostServices(dbContext);
			var x = postServices.GetSliderList();

			Assert.NotNull(x);
		}


		[Fact]
		public void AddSliderTest()
		{
			var postServices = new PostServices(dbContext);
			postServices.AddSlider(2);


			var x=dbContext.PostImages.ToList();

			Assert.Equal(6,x.Count());
		}


		[Fact]
		public void DeleteSliderTest()
		{
			var postServices = new PostServices(dbContext);
			postServices.DeleteSlider(1);


			var x = dbContext.PostImages.ToList();

			Assert.Equal(8, x.Count());
		}

		[Fact]
		public void DeletePostTest()
		{
			var postServices = new PostServices(dbContext);
			postServices.DeletePosts(1);


			var x = dbContext.Posts.ToList();

			Assert.Equal(7, x.Count());
		}





	}
}
