using Microsoft.AspNetCore.SignalR;

namespace Footballers_Catalog.Models
{
    public class FootballerHub : Hub
    {
        public async Task Send(int id, string firstName, string lastName, string sex, string country, string date, string team)
        {
            await Clients.All.SendAsync("Receive", firstName);
        }
    }
}
