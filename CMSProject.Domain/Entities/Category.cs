﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Categories")]
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }

		[Required]
		public string CategoryName { get; set; }


		public virtual ICollection<SubCategory> SubCategories { get; set; }

	}
}
