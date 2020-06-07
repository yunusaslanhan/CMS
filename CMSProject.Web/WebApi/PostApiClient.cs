using CMSProject.Common.Dtos;
using CMSProject.Web.WebApi.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMSProject.Web.WebApi
{
	public class PostApiClient : IPostApiClient
	{
		private readonly HttpClient _client;

		public PostApiClient(HttpClient client)
		{
			_client = client;
			_client.BaseAddress = new Uri("http://localhost:52599/api/posts/");
		}


		public async Task<List<PostDto>> GetPosts()
		{
			HttpResponseMessage response = await _client.GetAsync("GetPosts");
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<PostDto>>(data);
			}
			return null;
		}


		public async Task<List<SliderDto>> GetSliders()
		{
			HttpResponseMessage response = await _client.GetAsync("GetSliders");
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<SliderDto>>(data);
			}
			return null;
		}



		public async Task<List<PostDetailDto>> GetPostDetail(int id)
		{
			HttpResponseMessage response = await _client.GetAsync("GetPostDetail" + "/" + id);
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<PostDetailDto>>(data);
			}
			return null;
		}
		public async Task<List<PostDto>> GetMainPagePost(int id)
		{
			HttpResponseMessage response = await _client.GetAsync("GetMainPagePost" + "/" + id);
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<PostDto>>(data);
			}
			return null;
		}



	}
}
