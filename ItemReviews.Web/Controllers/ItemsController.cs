using System;
using ItemReviews.Data.Models;
using ItemReviews.Services;
using ItemReviews.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ItemReviews.Web.Controllers
{
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private readonly IItemService _itemService;

        public ItemsController(ILogger<ItemsController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpGet("/api/items")]
        public ActionResult GetItems()
        { 
            var items = _itemService.GetAllItems();
            return Ok(items);
        }
        
        [HttpGet("/api/items/{id}")]
        public ActionResult GetItem(int id)
        { 
            var item = _itemService.GetItem(id);
            return Ok(item);
        }
        
        [HttpPost("/api/items")]
        public ActionResult CreateItem([FromBody] NewItemRequest itemRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model state is not valid.");
            }
            var now = DateTime.UtcNow;
            
            var item = new Item
            {
                CreatedOn = now,
                UpdatedOn = now,
                ItemName = itemRequest.ItemName,
                Manufacturer = itemRequest.Manufacturer
            };
            _itemService.AddItem(item);
            return Ok($"Item created: {item.ItemName}");
        }
        
        [HttpDelete("/api/items/{id}")]
        public ActionResult DeleteItem(int id)
        { 
            _itemService.DeleteItem(id);
            return Ok($"BBQ item was deleted: {id}");
        }
    }
}
