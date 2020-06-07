using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSProject.Business.Services.Interfaces;
using CMSProject.Common.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace CMSProject.Web.Controllers
{
    public class LoginController : Controller
    {
		private readonly IDistributedCache _distributedCache;

		private IUserServices _userServices;

		public LoginController(IUserServices userServices, IDistributedCache distributedCache)
		{

			_userServices = userServices;
			_distributedCache = distributedCache;
		}

		public IActionResult Index()
        {
            return View();
        }


		public IActionResult PostLoginUserForAjax(UserDto userDto)
		{

			ViewBag.IsPost = true;

			var model = _userServices.LoginControl(userDto.Email, userDto.Password);

			if (model)
			{

				var loginUser = JsonConvert.SerializeObject(_userServices.GetByUserEmail(userDto.Email));
				//HttpContext.Session.SetString("User", loginUser);
				_distributedCache.SetString("User", loginUser);
				ViewBag.Result = true;

			}
			else
			{
				ViewBag.Result = false;


			}

			return Json(model);
		}


	}
}