using ToDo.Domain.Entities;

public class TodoService : ITodoService
{
    private readonly List<TodoItem> _todos = new();
    public List<TodoItem> GetAll() => _todos;

    public void Add(TodoItem item) => _todos.Add(item);
    public void MarkAsDone(Guid id)
    {
        var todo = _todos.FirstOrDefault(x => x.Id == id);
        todo?.MarkAsDone();
    }
}