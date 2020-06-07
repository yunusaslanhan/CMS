using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Common.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CMSProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	public class HomeController : Controller
    {
		private ILayoutService _layoutService;


		public HomeController(ILayoutService layoutService)
		{
			_layoutService = layoutService;
		}

		public IActionResult Index()
        {
            return View();
        }


		[HttpGet]
		public List<LayoutDto> GetLayoutList()
		{
			return _layoutService.GetLayoutList();
			

		}

	}
}