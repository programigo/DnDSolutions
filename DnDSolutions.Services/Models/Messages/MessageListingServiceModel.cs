using AutoMapper;
using DnDSolutions.Common.Mapping;
using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Chat;
using System;

namespace DnDSolutions.Services.Models.Messages
{
	public class MessageListingServiceModel : IMapFrom<Message>, IHaveCustomMapping
	{
		public int Id { get; set; }

		public string Text { get; set; }

		public DateTime SendOn { get; set; }

		public string UserName { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }

		public string RecipientId { get; set; }

		public void ConfigureMapping(Profile mapper)
		 => mapper
			.CreateMap<Message, MessageListingServiceModel>()
			.ForMember(m => m.UserId, cfg => cfg.MapFrom(msg => msg.UserId));
	}
}
