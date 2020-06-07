using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class MainPageDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int ParentId { get; set; }

		public DateTime CreateDate { get; set; }
	}
}
