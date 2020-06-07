using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Layouts")]
	public class Layout
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public DateTime CreateDate { get; set; }


		public virtual ICollection<Post> Posts { get; set; }

		public virtual ICollection<LayoutComponent> LayoutComponents { get; set; }

	}
}
