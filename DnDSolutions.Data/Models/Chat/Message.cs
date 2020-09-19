using System;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Chat
{
	public class Message
	{
		public int Id { get; set; }

		[Required]
		public string Text { get; set; }

		public DateTime SendOn { get; set; }

		[Required]
		public string UserName { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }

		public string RecipientId { get; set; }
	}
}
