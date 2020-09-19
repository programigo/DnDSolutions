using DnDSolutions.Data.Models.Chat;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DnDSolutions.Web.SignalRChat.Hubs
{
	public class ChatHub : Hub
	{
		public Task SendPrivateMessage(Message message)
		{
			return Clients.Users(message.UserId, message.RecipientId).SendAsync("receiveMessage", message);
		}
	}
}
