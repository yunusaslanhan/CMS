using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("PostImages")]
	public class PostImage
	{
		[Key]
		public int PostImageId { get; set; }

		[Required]
		public int PostId { get; set; }
		public Post Post { get; set; }

		public string Image { get; set; }

		public string Desc { get; set; }
	}
}
