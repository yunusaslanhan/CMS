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
	public class MainPageApiClient:IMainPageApiClient
	{
		private readonly HttpClient _client;

		public MainPageApiClient(HttpClient client)
		{
			_client = client;
			_client.BaseAddress = new Uri("http://localhost:52599/api/mainpages/");
		}
		public async Task<List<MainPageDto>> GetMainPages()
		{
			HttpResponseMessage response = await _client.GetAsync("GetMainPages");
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<MainPageDto>>(data);
			}
			return null;
		}

		public async Task<string> GetGenerateMenuUi()
		{

			HttpResponseMessage response = await _client.GetAsync("GetGenerateMenuUi");
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			return null;


		}


	}
}
