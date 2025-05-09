using ToDo.Domain.Entities;

public class CreateTodoItem
{
    private readonly ITodoRepository _repository;

    public CreateTodoItem(ITodoRepository repository)
    {
        _repository = repository;
    }

    public void Execute(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");

        var item = new TodoItem { Title = title };
        _repository.Add(item);
    }
}