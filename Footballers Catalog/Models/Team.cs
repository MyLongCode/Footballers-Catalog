using Microsoft.EntityFrameworkCore;
namespace Footballers_Catalog.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Footballer> Footballers { get; set; }
    }
}
