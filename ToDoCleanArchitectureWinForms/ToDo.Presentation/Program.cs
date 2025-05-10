using ToDo.Infrastructure;

namespace ToDo.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ITodoRepository todoRepo = new InMemoryTodoRepository();

            var createUseCase = new CreateTodoItem(todoRepo);
            var markDoneUseCase = new MarkTodoItemAsDone(todoRepo);

            Application.Run(new Form1(todoRepo, createUseCase, markDoneUseCase));
        }
    }
}