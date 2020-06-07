using CMSProject.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Business.Services.Interfaces
{
	public interface IPostServices
	{
		void SavePost(PostDto postDto);
		List<PostDto> GetPostList();
		List<PostDetailDto> GetPostDetailList(int id);
		List<PostDto> GetMainPagePostList(int id);
		void DeletePosts(int id);
		List<SliderDto> GetSliderList();
		void AddSlider(int PostId);
		void DeleteSlider(int id);
	}
}
