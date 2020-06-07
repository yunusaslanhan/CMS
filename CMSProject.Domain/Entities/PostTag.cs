using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("PostTags")]
	public class PostTag
	{
		[Key, Column(Order = 0)]
		[ForeignKey("PostId")]
		public int PostId { get; set; }
		public Post Post { get; set; }

		
		[Key,Column(Order=1)]
		[ForeignKey("TagId")]
		public int TagId { get; set; }
		public Tag Tag { get; set; }
	
		

	}
}
