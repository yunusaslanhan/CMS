using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class LayoutComponentDto
	{
		public int Id { get; set; }

		public int LayoutId { get; set; }

		public string Size { get; set; }

		public DateTime CreateTime { get; set; }

		public string Name { get; set; }

		public string ComponentClass { get; set; }

	}
}
