using DnDSolutions.Services.Models.Messages;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Services
{
	public interface IMessageService
	{
		void Create(string text, DateTime sendOn, string userName, string userId, string recipientId);

		List<MessageListingServiceModel> GetConversationMessages(string senderId, string recipientId);

		List<MessageListingServiceModel> GetAllUserMessages(string userId);

		MessageListingServiceModel GetConversationLastMessage(string senderId, string recipientId);
	}
}
