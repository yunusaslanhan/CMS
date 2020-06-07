using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("LayoutComponents")]
	public class LayoutComponent
	{

		[Key]
		public int Id { get; set; }

		[Required]
		public int LayoutId { get; set; }
		public Layout Layout { get; set; }


		[Required]
		public string Size { get; set; }

		[Required]
		public DateTime CreateTime { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string ComponentClass { get; set; }

	}
}
