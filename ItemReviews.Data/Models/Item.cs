using System;

namespace ItemReviews.Data.Models
{
    //shape of my first grill items data.  Will be mapped to our slq tables with entity framework
    public class Item
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }

        // Will add an item description on refactor
       // public string Description { get; set; }

    }
}