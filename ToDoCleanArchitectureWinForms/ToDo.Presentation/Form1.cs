using ToDo.Domain.Entities;

namespace ToDo.Presentation
{
    public partial class Form1 : Form
    {
        private readonly ITodoService _todoService;

        public Form1(ITodoService todoService)
        {
            InitializeComponent();
            _todoService = todoService;
            RefreshTodoList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var todo = new TodoItem { Title = txtTitle.Text };
            _todoService.Add(todo);
            RefreshTodoList();
        }

        private void RefreshTodoList()
        {
            lstToDos.Items.Clear();
            foreach (var item in _todoService.GetAll())
            {
                lstToDos.Items.Add($"{item.Title} - {(item.IsDone ? "Done" : "Pending")}");
            }
        }
    }
}
