using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Web.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CMSProject.Web.Controllers
{
    public class UserController : Controller
    {
		
		private IPostApiClient _postApiClient;
		private IMainPageApiClient _mainPageApiClient;

		private IMainPageServices _mainPageServices;
		private IPostServices _postServices;


		public UserController(IMainPageServices mainPageServices, IPostServices postServices, IPostApiClient postApiClient, IMainPageApiClient mainPageApiClient)
		{
			_postApiClient = postApiClient;
			_mainPageApiClient = mainPageApiClient;

			_mainPageServices = mainPageServices;
			_postServices = postServices;
			
		}


		public async Task<IActionResult> Index()
        {
			var model = await _postApiClient.GetPosts();

			var menu = await _mainPageApiClient.GetGenerateMenuUi();

			var slider = await _postApiClient.GetSliders();

			ViewBag.Menu = menu;

			ViewBag.Slider = slider;

			return View(model);
			
        }

		public async Task<IActionResult> PostDetailPage(int id)
		{
			var model = await _postApiClient.GetPostDetail(id);

			var menu = await _mainPageApiClient.GetGenerateMenuUi();  

			ViewBag.Menu = menu;

			return View(model);

		}


		public async Task<IActionResult> MainPagePost(int id)
		{
			var model = await _postApiClient.GetMainPagePost(id);

			var menu = await _mainPageApiClient.GetGenerateMenuUi();

			ViewBag.Menu = menu;

			return View(model);

		}

		
	}
}