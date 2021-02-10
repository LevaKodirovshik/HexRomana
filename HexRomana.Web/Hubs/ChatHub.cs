using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace HexRomana.Web.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message).ConfigureAwait(false);
        }
    }
}
