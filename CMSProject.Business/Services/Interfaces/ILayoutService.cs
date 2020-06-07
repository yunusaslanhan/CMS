using CMSProject.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Business.Services.Interfaces
{
	public interface ILayoutService
	{
		void SaveLayout(LayoutDto layoutDto);
		List<LayoutDto> GetLayoutList();
		List<LayoutComponentDto> GetLayoutComponentList(int LayoutId);


		}
}
