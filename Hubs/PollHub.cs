using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotacaoOnlineComSignalR.Hubs
{
    public class PollHub : Hub
    {
        public async Task SendMessageAsync(string user, string message, string myChannelId, string myChannelVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myChannelId, myChannelVal).ConfigureAwait(false);
        }
    }
}
