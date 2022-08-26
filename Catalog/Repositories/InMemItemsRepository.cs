using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {

        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Joe Abriba", Price = 30, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sandy Abriba", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Melissa Abriba", Price = 10, CreatedDate = DateTimeOffset.UtcNow }

        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.SingleOrDefault(item => item.Id == id);
        }
    }
}
