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
	public class PostServices : IPostServices
	{
		private CMSContext _dbContext;

		public PostServices(CMSContext dbContext)
		{
			_dbContext = dbContext;
		}



		public void SavePost(PostDto postDto)
		{

			var model = _dbContext.Posts.Add(new Post
			{
				LayoutId = postDto.LayoutId,
				UserId = 3,
				PostTitle = postDto.PostTitle,
				CreateDate = DateTime.Now,
				SubCategoryId = 1,
				PostDesc = postDto.PostDesc,
				PostPhoto = postDto.PostPhoto,
				MainPageId = postDto.MainPageId
			});

			foreach (var item in postDto.postDetailDtos)
			{
				_dbContext.PostDetails.Add(new PostDetail
				{
					PostId = model.Entity.PostId,
					PostHtml = item.PostHtml,
					CreateDate = DateTime.Now

				});

			}



			_dbContext.SaveChanges();

		}


		public List<PostDto> GetPostList()
		{

			var model = _dbContext.Posts.Select(p => new PostDto
			{
				PostId = p.PostId,
				LayoutId = p.LayoutId,
				UserId = p.UserId,
				SubCategoryId = p.SubCategoryId,
				PostTitle = p.PostTitle,
				PostDesc = p.PostDesc,
				PostPhoto = p.PostPhoto,
				CreateDate = p.CreateDate


			}).ToList();

			return model;


		}

		public PostDto GetPostById(int PostId)
		{
			var model = _dbContext.Posts.Where(p => p.PostId == PostId).Select(p => new PostDto
			{
				PostId = p.PostId,
				LayoutId = p.LayoutId,
				UserId = p.UserId,
				SubCategoryId = p.SubCategoryId,
				PostTitle = p.PostTitle,
				PostDesc = p.PostDesc,
				PostPhoto = p.PostPhoto,
				CreateDate = p.CreateDate


			}).Single();

			return model;
		}


		public List<PostDetailDto> GetPostDetailList(int id)
		{

			var model = _dbContext.PostDetails.Where(p => p.PostId == id).Select(p => new PostDetailDto
			{
				PostId = p.PostId,
				Id = p.Id,
				PostHtml = p.PostHtml,
				CreateDate = p.CreateDate


			}).ToList();

			return model;


		}

		public List<PostDto> GetMainPagePostList(int id)
		{

			var model = _dbContext.Posts.OrderByDescending(p => p.CreateDate).Where(p => p.MainPageId == id).Select(p => new PostDto
			{
				PostId = p.PostId,
				LayoutId = p.LayoutId,
				UserId = p.UserId,
				SubCategoryId = p.SubCategoryId,
				PostTitle = p.PostTitle,
				PostDesc = p.PostDesc,
				PostPhoto = p.PostPhoto,
				CreateDate = p.CreateDate


			}).ToList();

			return model;


		}


		public void DeletePosts(int id)
		{

			var detailList = _dbContext.PostDetails.Where(p => p.PostId == id).ToList();

			foreach (var item in detailList)
			{
				_dbContext.PostDetails.Remove(item);
			}


			var list = _dbContext.Posts.Where(p => p.PostId == id).FirstOrDefault();

			_dbContext.Posts.Remove(list);


			_dbContext.SaveChanges();

		}

		public void DeleteSlider(int id)
		{
			var slider = _dbContext.PostImages.Where(p => p.PostImageId == id).FirstOrDefault();
			_dbContext.PostImages.Remove(slider);

			_dbContext.SaveChanges();

		}
		

		public List<SliderDto> GetSliderList()
		{

			var model = _dbContext.PostImages.Select(p => new SliderDto
			{
				PostImageId = p.PostImageId,
				PostId = p.PostId,
				Desc = p.Desc,
				Image = p.Image

			}).ToList();

			return model;


		}
		public void AddSlider(int PostId)
		{
			var model = GetPostById(PostId);


			_dbContext.PostImages.Add(new PostImage
			{
				PostId = PostId,
				Image=model.PostPhoto,
				Desc=model.PostTitle
				
			}
				);

			_dbContext.SaveChanges();
		}





	}
}
