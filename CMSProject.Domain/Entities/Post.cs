using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Posts")]
	public class Post
	{
		[Key]
		public int PostId { get; set; }

		[Required]
		public int UserId { get; set; }
		public User User { get; set; }


		public string PostTitle { get; set; }

		public string PostDesc { get; set; }

		public string PostPhoto { get; set; }

		[Required]
		public DateTime CreateDate { get; set; }


		[Required]
		public int SubCategoryId { get; set; }
		public SubCategory SubCategory { get; set; }

		[Required]
		public int LayoutId { get; set; }
		public Layout Layout { get; set; }

		[ForeignKey("MainPageId")]
		public int MainPageId { get; set; }
		public MainPage MainPage { get; set; }

		public virtual ICollection<PostComment> PostComments { get; set; }
		public virtual ICollection<PostImage> PostImages { get; set; }
		



	}
}
