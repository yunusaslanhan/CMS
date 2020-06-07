using System;
using System.Collections.Generic;
using System.Text;

namespace CMSProject.Common.Dtos
{
	public class PostDto
	{
		public int PostId { get; set; }

		public int UserId { get; set; }

		public string PostTitle { get; set; }

		public DateTime CreateDate { get; set; }

		public int SubCategoryId { get; set; }

		public int LayoutId { get; set; }

		public string PostDesc { get; set; }

		public string PostPhoto { get; set; }

		public int MainPageId { get; set; }

		public List<PostDetailDto> postDetailDtos { get; set; }

		public List<PostDto> postDtos { get; set; }

		public List<SliderDto> sliderDtos { get; set; }



	}
}
