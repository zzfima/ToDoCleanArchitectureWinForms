public class MarkTodoItemAsDone
{
    private readonly ITodoRepository _repository;

    public MarkTodoItemAsDone(ITodoRepository repository)
    {
        _repository = repository;
    }

    public void Execute(Guid id)
    {
        var item = _repository.GetById(id);
        if (item == null)
            throw new Exception("Item not found.");

        item.MarkAsDone();
        _repository.Update(item);
    }
}