using CMSProject.WebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CMSProject.XUnitTest
{
	public class UnitTest1
	{
		private readonly TestServer _server;
		private readonly HttpClient _client;

		public UnitTest1()
		{
			_server = new TestServer(new WebHostBuilder()
	        .UseStartup<Startup>());
			_client = _server.CreateClient();
		}

		[Fact]
		public async Task GetPostTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/posts/GetPosts");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}


		[Fact]
		public async Task GetSlidersTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/posts/GetSliders");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}

		[Fact]
		public async Task GetPostDetailTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/posts/GetPostDetail/12");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}

		[Fact]
		public async Task GetMainPagePostTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/posts/GetMainPagePost/3");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}

		[Fact]
		public async Task GetLayoutsTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/layouts/GetLayouts");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}

		[Fact]
		public async Task GetMainPagesTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/mainpages/GetMainPages");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}

		[Fact]
		public async Task GetGenerateMenuUiTest()
		{
			// Act
			var response = await _client.GetAsync("http://localhost:52599/api/mainpages/GetGenerateMenuUi");
			response.EnsureSuccessStatusCode();
			var responseString = await response.Content.ReadAsStringAsync();
			// Assert
			Assert.NotNull(responseString);
		}


	}
}
