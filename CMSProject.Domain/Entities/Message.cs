using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMSProject.Domain.Entities
{
	[Table("Messages")]
	public class Message
	{
		[Key]
		public int MessageId { get; set; }

		public int FromId { get; set; }
		[ForeignKey("FromId")]
		public User FromUser { get; set; }

		public int ToId { get; set; }
		[ForeignKey("ToId")]
		public User ToUser { get; set; }

		[Required]
		public string MessageText { get; set; }


	}
}
