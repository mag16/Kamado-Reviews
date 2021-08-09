using System;


// model created for second refactor as I add a review component on the front end
namespace ItemReviews.Data.Models
{
    public class ItemReview
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }
        
        //property created to map each item to its review
        //public Item Item { get; get; }
    }
}