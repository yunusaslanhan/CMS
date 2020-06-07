using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class LayoutDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime CreateDate { get; set; }

		public List<LayoutComponentDto> layoutComponentDtos { get; set; }
		public List<LayoutDto> layoutDtos { get; set; }
		public List<MainPageDto> mainPageDtos { get; set; }



	}
}
