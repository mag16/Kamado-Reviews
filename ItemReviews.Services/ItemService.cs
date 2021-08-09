using System;
using System.Collections.Generic;
using System.Linq;
using ItemReviews.Data;
using ItemReviews.Data.Models;

namespace ItemReviews.Services
{
    //implement interface behavior here
    public class ItemService : IItemService
    {
        //stores data exposed by public prop below
        private readonly ItemReviewsDbContext _db;
        
        //inject backing field into service
        public ItemService(ItemReviewsDbContext db)
        {
            _db = db;
        }
        //using entity frameworks methods toList to return all items as a list from the system.
        public List<Item> GetAllItems()
        {
            return _db.Items.ToList();
        }

        public Item GetItem(int itemId)
        {
            // var item = _db.Items.First(item => item.Id == itemId);
            return _db.Items.Find(itemId);
        }

        public void AddItem(Item item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void DeleteItem(int itemId)
        {
            var itemToDelete = _db.Items.Find(itemId);
            if (itemToDelete != null)
            {
                _db.Remove(itemToDelete);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Cannot delete Item that does not exist");
            }
        }
    }
}
