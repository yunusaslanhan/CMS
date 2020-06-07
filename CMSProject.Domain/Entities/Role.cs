using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Roles")]
	public class Role
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string RoleName { get; set; }


		public virtual ICollection<User> Users { get; set; }	

	}
}
