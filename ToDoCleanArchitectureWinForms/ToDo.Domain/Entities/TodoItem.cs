namespace ToDo.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; private set; }
        public void MarkAsDone() => IsDone = true;
        public override string ToString() => $"{Title} - {(IsDone ? "Done" : "Pending")}";
    }
}
