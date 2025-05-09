using ToDo.Domain.Entities;

public interface ITodoRepository
{
    void Add(TodoItem item);
    void Update(TodoItem item);
    TodoItem? GetById(Guid id);
    List<TodoItem> GetAll();
}