using CMSProject.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Business.Services.Interfaces
{
	public interface IMainPageServices
	{
		List<MainPageDto> GetMainPageList();
		void AddPage(int ParentId, string Name);
		string GenerateMenuUi();
		void AddChildItem(MainPageDto childItem, StringBuilder strBuilder);

	}
}
