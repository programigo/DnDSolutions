using System;

namespace DnDSolutions.Web.Models.Messages
{
	public class MessageItemViewModel
	{
		public string UserId { get; set; }

		public string Username { get; set; }

		public string Text { get; set; }

		public DateTime SendOn { get; set; }
	}
}
