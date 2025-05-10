using ToDo.Domain.Entities;

namespace ToDo.Infrastructure
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _items = new();

        public void Add(TodoItem item)
        {
            _items.Add(item);
        }

        public void Update(TodoItem item)
        {
            var index = _items.FindIndex(x => x.Id == item.Id);
            if (index != -1)
            {
                _items[index] = item;
            }
        }

        public TodoItem? GetById(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public List<TodoItem> GetAll()
        {
            // Return a shallow copy to avoid outside modification
            return _items.ToList();
        }
    }
}
