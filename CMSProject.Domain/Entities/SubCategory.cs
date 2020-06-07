using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("SubCategories")]
	public class SubCategory
	{
		[Key]
		public int SubCategoryId { get; set; }

		[Required]
		public int CategoryId { get; set; }
		public Category Category { get; set; }

		[Required]
		[StringLength(50)]
		public string SubCategoryName { get; set; }
		
		
		public virtual ICollection<Post> Posts { get; set; }	

	}
}
