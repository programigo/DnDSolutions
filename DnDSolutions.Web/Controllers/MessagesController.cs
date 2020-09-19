using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Chat;
using DnDSolutions.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
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

			return View(message);
		}
	}
}
