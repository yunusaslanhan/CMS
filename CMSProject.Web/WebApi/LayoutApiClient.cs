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
	public class LayoutApiClient : ILayoutApiClient
	{
		private readonly HttpClient _client;

		public LayoutApiClient(HttpClient client)
		{
			_client = client;
			_client.BaseAddress = new Uri("http://localhost:52599/api/layouts/");
		}

		public async Task<List<LayoutDto>> GetLayouts()
		{
			HttpResponseMessage response = await _client.GetAsync("GetLayouts");
			if (response.IsSuccessStatusCode)
			{
				var data = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<LayoutDto>>(data);
			}
			return null;
		}
	}
}
