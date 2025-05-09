namespace ToDo.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; set; }
        public bool IsDone { get; private set; }
        public void MarkAsDone() => IsDone = true;
    }
}
