using System;

namespace Catalog.Models
{
    // a record can be equal to another just by their properties values being the same
    public record Item
    {
        // init -> 'set' the value only on its initialization
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}