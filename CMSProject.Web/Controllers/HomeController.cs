using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMSProject.Web.Models;
using Microsoft.Extensions.Caching.Distributed;
using CMSProject.Common.Dtos;
using CMSProject.Business.Services.Interfaces;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using CMSProject.Web.WebApi.Interfaces;

namespace CMSProject.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDistributedCache _distributedCache;

		private ILayoutApiClient _layoutApiClient;
		private IPostApiClient _postApiClient;
		private IMainPageApiClient _mainPageApiClient;

		private ILayoutService _layoutService;
		private IPostServices _postServices;
		private IMainPageServices _mainPageServices;
		private readonly IHostingEnvironment he;
		public static PostDto _post;
		


		public HomeController(IDistributedCache distributedCache, ILayoutService layoutService, IPostServices postServices, IMainPageServices mainPageServices, IHostingEnvironment e, ILayoutApiClient layoutApiClient, IPostApiClient postApiClient, IMainPageApiClient mainPageApiClient)
		{
			_distributedCache = distributedCache;
			_layoutService = layoutService;
			_postServices = postServices;
			_mainPageServices = mainPageServices;
			he = e;

			_layoutApiClient = layoutApiClient;
			_postApiClient = postApiClient;
			_mainPageApiClient = mainPageApiClient;

		}


		public async Task<IActionResult> Index()
		{

			//UserDto usermodel = JsonConvert.DeserializeObject<UserDto>(HttpContext.Session.GetString("User"));
			//ViewBag.Name = usermodel.UserName;


			UserDto usermodel = JsonConvert.DeserializeObject<UserDto>(_distributedCache.GetString("User"));
			ViewBag.Name = usermodel.UserName;


			return View();
		}

		[HttpPost]
		public IActionResult SaveLayout([FromBody]LayoutDto layout)
		{

			_layoutService.SaveLayout(layout);

			return Json("/Home/");



		}

		
		public async Task<IActionResult> ListLayout()
		{

			var model = await _layoutApiClient.GetLayouts();

			return View(model);
		}


		[HttpGet]
		public async Task<IActionResult> ListPost()
		{
			var model = await _postApiClient.GetPosts();

			return View(model);

		}

		[HttpGet]
		public async Task<IActionResult> AddPost()
		{

			LayoutDto layoutDto = new LayoutDto();

			layoutDto.layoutDtos = await _layoutApiClient.GetLayouts();

			layoutDto.mainPageDtos = await _mainPageApiClient.GetMainPages();


			return View(layoutDto);

		}

		[HttpGet]
		public async Task<IActionResult> AddMainPage()
		{
			var model = await _mainPageApiClient.GetMainPages();

			var menu = await _mainPageApiClient.GetGenerateMenuUi();

			ViewBag.Menu = menu;

			return View(model);

		}

		[HttpGet]
		public async Task<IActionResult> AddSlider()
		{
			PostDto postDto = new PostDto();

			var model = await _postApiClient.GetPosts();

			var slider = await _postApiClient.GetSliders();

			postDto.postDtos = model;
			postDto.sliderDtos = slider;
			
			return View(postDto);

		}


		[HttpPost]
		public IActionResult LayoutDesign(int LayoutId)
		{

			LayoutDto layoutDto = new LayoutDto();

			layoutDto.layoutComponentDtos = _layoutService.GetLayoutComponentList(LayoutId);

			return PartialView("PostPartial", layoutDto);
		}


		[HttpPost]
		public IActionResult AddPageForAjax(int ParentId, string Name)
		{

			_mainPageServices.AddPage(ParentId, Name);

			var model = _mainPageServices.GetMainPageList();

			var menu = _mainPageServices.GenerateMenuUi();

			ViewBag.Menu = menu;

			return PartialView("MainPagePartial", model);
		}


		[HttpPost]
		public IActionResult AddSliderForAjax(int PostId)
		{

			_postServices.AddSlider(PostId);

			var model = _postServices.GetSliderList();


			return PartialView("SliderPartial", model);
		}



		[HttpPost]
		public IActionResult SavePage()
		{

			_postServices.SavePost(_post);


			return Json(true);


		}


		[HttpPost]
		public IActionResult PreviewPage(string pageDto, IFormFile inputPic)
		{
			var pageContents = JsonConvert.DeserializeObject<PostDto>(pageDto);
			string PostHtmlContent = "";

			foreach (var item in pageContents.postDetailDtos)
			{
				PostHtmlContent = PostHtmlContent + item.PostHtml;
			}


			if (inputPic != null)
			{
				var guid = Guid.NewGuid().ToString().Replace("-", "");
				var fileName = Path.Combine(he.WebRootPath, "images", "pageThumbnails",
					guid + Path.GetFileName(inputPic.FileName));
				var dbFileName = Path.Combine("images", "pageThumbnails", guid + Path.GetFileName(inputPic.FileName));
				inputPic.CopyTo(new FileStream(fileName, FileMode.Create));
				pageContents.PostPhoto = dbFileName;
			}




			_post = pageContents;
			return Json(PostHtmlContent);

		}

		public IActionResult DeletePost(int PostId)
		{
			_postServices.DeletePosts(PostId);

			var model = _postServices.GetPostList();

			return PartialView("ListPostPartial", model);


		}

		public IActionResult DeleteSlider(int PostImageId)
		{
			_postServices.DeleteSlider(PostImageId);

			var model = _postServices.GetSliderList();

			return PartialView("SliderPartial", model);

		}




		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
