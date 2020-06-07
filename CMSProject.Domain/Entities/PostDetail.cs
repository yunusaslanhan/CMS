using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("PostDetails")]
	public class PostDetail
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int PostId { get; set; }
		public Post Post { get; set; }

		[Required]
		public string PostHtml { get; set; }
		
		[Required]
		public DateTime CreateDate { get; set; }

	}
}
