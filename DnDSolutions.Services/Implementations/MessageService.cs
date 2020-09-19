using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Data.Models.Chat;
using DnDSolutions.Services.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
	public class MessageService : IMessageService
	{
		private readonly DnDSolutionsDbContext db;
		private readonly IConfigurationProvider provider;

		public MessageService(DnDSolutionsDbContext db, IConfigurationProvider provider)
		{
			this.db = db;
			this.provider = provider;
		}

		public void Create(string text, DateTime sendOn, string userName, string userId, string recipientId)
		{
			Message message = new Message
			{
				Text = text,
				SendOn = sendOn,
				UserName = userName,
				UserId = userId,
				RecipientId = recipientId,
			};

			this.db.Add(message);

			this.db.SaveChanges();
		}

		public List<MessageListingServiceModel> GetConversationMessages(string senderId, string recipientId)
		{
			var currentUserMessages = this.db
			.Messages
			.Where(m => m.UserId == senderId)
			.Where(m => m.RecipientId == recipientId)
			.ProjectTo<MessageListingServiceModel>(this.provider)
			.ToList();

			var recipientMessages = this.db
			.Messages
			.Where(m => m.UserId == recipientId)
			.Where(m => m.RecipientId == senderId)
			.ProjectTo<MessageListingServiceModel>(this.provider)
			.ToList();

			List<MessageListingServiceModel> result = new List<MessageListingServiceModel>();
			result.AddRange(currentUserMessages);
			result.AddRange(recipientMessages);
			result = result.OrderBy(m => m.SendOn).ToList();

			return result;
		}
	}
}
