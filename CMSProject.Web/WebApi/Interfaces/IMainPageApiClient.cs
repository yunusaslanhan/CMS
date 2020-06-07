using CMSProject.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSProject.Web.WebApi.Interfaces
{
	public interface IMainPageApiClient
	{
		Task<List<MainPageDto>> GetMainPages();
		Task<string> GetGenerateMenuUi();
	}
}
