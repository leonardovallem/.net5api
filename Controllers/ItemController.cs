using System;
using System.Collections.Generic;
using Catalog.Models;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]     // default to controller's name -> [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemsRepo _repo;

        public ItemController()
        {
            _repo = new InMemItemsRepo();
        }

        [HttpGet]   // GET /items
        public IEnumerable<Item> GetItems()
        {
            return _repo.GetItems();
        }

        [HttpGet("{id}")]   // GET /items/:id
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = _repo.GetItem(id);
            return item is null ? NotFound() : item;
        }
    }
}