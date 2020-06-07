using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class PostDetailDto
	{
		public int Id { get; set; }

		public int PostId { get; set; }

		public string PostHtml { get; set; }

		public DateTime CreateDate { get; set; }

	}
}
