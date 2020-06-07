using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Users")]
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		[StringLength(50)]
		public string UserName { get; set; }

		[Required]
		[StringLength(50)]
		public string Password { get; set; }


		[Required]
		[StringLength(50)]
		public string Email { get; set; }

		

		[Required]
		public int RoleId { get; set; }
		public Role Role;


		[StringLength(100)]
		public string Photo { get; set; }
		
		[InverseProperty("FromUser")]
		public ICollection<Message> FromMessage { get; set; }

		[InverseProperty("ToUser")]
		public ICollection<Message> ToMessage { get; set; }


		public virtual ICollection<Post> Posts { get; set; }

		[InverseProperty("User")]
		public virtual ICollection<PostComment> PostComments { get; set; }

	}
}
