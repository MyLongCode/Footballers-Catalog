using Microsoft.AspNetCore.SignalR;

namespace Footballers_Catalog.Models
{
    public class FootballerHub : Hub
    {
        public async Task Send(Footballer footballer)
        {
            await Clients.All.SendAsync("Receive", footballer);
        }
    }
}
