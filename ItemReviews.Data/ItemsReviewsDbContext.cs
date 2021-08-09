using ItemReviews.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemReviews.Data
{
    public class ItemReviewsDbContext : DbContext
    {
        public ItemReviewsDbContext() {}

        public ItemReviewsDbContext(DbContextOptions options) : base(options)
        {
            
        }
        // database definitions sets (for our tables)
        public virtual DbSet<Item> Items { get; set; }
        //Will use in second iteration when reviews are implemented
        public virtual DbSet<ItemReview> ItemReviews { get; set; }
    }
}