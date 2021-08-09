using System.Collections.Generic;
using ItemReviews.Data.Models;

namespace ItemReviews.Services
{
    //define the behavior of our class here
    public interface IItemService
    {
        public List<Item> GetAllItems();
        public Item GetItem(int itemId);
        public void AddItem(Item item);
        public void DeleteItem(int itemId);
    }
}