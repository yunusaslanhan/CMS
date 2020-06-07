
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("MainPages")]
	public class MainPage
	{
		[Key]
		public int Id { get; set; }

		[StringLength(50)]
		public string Name { get; set; }


		public int ParentId { get; set; }

		public DateTime CreateDate { get; set; }

		

	}
}
