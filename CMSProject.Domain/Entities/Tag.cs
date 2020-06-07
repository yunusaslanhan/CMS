using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Tags")]
	public class Tag
	{
		[Key]
		public int TagId { get; set; }

		[Required]
		[StringLength(50)]
		public string TagName { get; set; }

		

	}
}
