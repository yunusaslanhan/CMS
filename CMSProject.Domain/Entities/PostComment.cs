using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("PostComments")]
	public class PostComment
	{
		[Key]
		public int PostCommentId { get; set; }

		[ForeignKey("PostId")]	
		[Required]
		public int PostId { get; set; }
		public Post Post { get; set; }

		[ForeignKey("UserId")]
		[Required]
		public int UserId { get; set; }
		public User User { get; set; }

		[Required]
		public string CommentText { get; set; }

		[Required]
		public DateTime CreateDate { get; set; }

	}
}
