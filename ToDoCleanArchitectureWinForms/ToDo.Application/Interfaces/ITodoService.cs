using ToDo.Domain.Entities;

public interface ITodoService
{
    List<TodoItem> GetAll();
    void Add(TodoItem item);
    void MarkAsDone(Guid id);
}