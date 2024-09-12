using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data
{
    public class AuctionDbcontext : DbContext
    {
        public AuctionDbcontext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
