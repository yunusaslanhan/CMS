using CMSProject.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSProject.Web.WebApi.Interfaces
{
	public interface IPostApiClient
	{
		Task<List<PostDto>> GetPosts();
		Task<List<PostDetailDto>> GetPostDetail(int id);
		Task<List<PostDto>> GetMainPagePost(int id);
		Task<List<SliderDto>> GetSliders();
	}
}
