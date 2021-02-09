using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Models;

namespace Catalog.Repositories
{
    public class InMemItemsRepo
    {
        private readonly List<Item> _items = new()
        {
            new Item() { Id = Guid.NewGuid(), Name = "Ryzen 5 3600", Price = 1500, CreatedDate = DateTimeOffset.UtcNow },
            new Item() { Id = Guid.NewGuid(), Name = "Ryzen 7 3800X", Price = 2500, CreatedDate = DateTimeOffset.UtcNow },
            new Item() { Id = Guid.NewGuid(), Name = "Ryzen 9 3950X", Price = 5500, CreatedDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return _items;
        }

        public Item GetItem(Guid id)
        {
            return _items.SingleOrDefault(item => item.Id.Equals(id));
        }
    }
}