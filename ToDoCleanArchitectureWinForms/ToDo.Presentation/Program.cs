namespace ToDo.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ITodoService todoService = new TodoService();
            Application.Run(new Form1(todoService));
        }
    }
}