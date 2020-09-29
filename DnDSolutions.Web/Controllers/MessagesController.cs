﻿using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Chat;
using DnDSolutions.Services;
using DnDSolutions.Services.Models.Messages;
using DnDSolutions.Web.Models.Messages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDSolutions.Web.Controllers
{
	[Authorize]
	public class MessagesController : Controller
	{
		private readonly UserManager<User> userManager;
		private readonly IMessageService messageService;

		public MessagesController(UserManager<User> userManager, IMessageService messageService)
		{
			this.userManager = userManager;
			this.messageService = messageService;
		}

		public async Task<IActionResult> Index([FromQuery] string recipientId)
		{
			User recipient = await this.userManager.FindByIdAsync(recipientId);

			if (recipient == null)
			{
				return NotFound();
			}

			User currentUser = await this.userManager.GetUserAsync(User);

			if (currentUser.Id == recipientId)
			{
				return BadRequest();
			}

			ViewBag.CurrentUserName = currentUser.UserName;
			ViewBag.CurrentUserId = currentUser.Id;
			ViewBag.RecipientId = recipientId;
			var messages = this.messageService.GetConversationMessages(currentUser.Id, recipientId);

			return View(messages);
		}

		public async Task<IActionResult> Create(Message message)
		{
			if (ModelState.IsValid)
			{
				User currentUser = await this.userManager.GetUserAsync(User);
				this.messageService.Create(message.Text, DateTime.UtcNow, currentUser.UserName, this.userManager.GetUserId(User), message.RecipientId);
				return Ok();
			}

			return BadRequest();
		}

		public async Task<IActionResult> All()
		{
			string currentUserId = this.userManager.GetUserId(User);

			var messagesUserIds = this.messageService
				.GetAllUserMessages(currentUserId)
				.Select(m => new { m.UserId, m.RecipientId })
				.Distinct();

			var interlocutorIds = new List<string>();

			foreach (var item in messagesUserIds)
			{
				if (item.UserId != currentUserId)
				{
					interlocutorIds.Add(item.UserId);
				}

				if (item.RecipientId != currentUserId)
				{
					interlocutorIds.Add(item.RecipientId);
				}
			}

			interlocutorIds = interlocutorIds.Distinct().ToList();

			var result = new List<MessageItemViewModel>();

			foreach (string interlocutorId in interlocutorIds)
			{
				MessageListingServiceModel conversationLastMessage = this.messageService.GetConversationLastMessage(currentUserId, interlocutorId);
				string messageUserId = conversationLastMessage.UserId == currentUserId
					? conversationLastMessage.RecipientId
					: conversationLastMessage.UserId;

				User interlocutor = await this.userManager.FindByIdAsync(messageUserId);

				result.Add(new MessageItemViewModel
				{
					UserId = messageUserId,
					Username = interlocutor.UserName,
					Text = conversationLastMessage.Text,
					SendOn = conversationLastMessage.SendOn,
				});
			}

			return View(result);
		}
	}
}
