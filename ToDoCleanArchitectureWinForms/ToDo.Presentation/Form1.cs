using ToDo.Domain.Entities;

namespace ToDo.Presentation
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepository _repo;
        private readonly CreateTodoItem _create;
        private readonly MarkTodoItemAsDone _markDone;

        public Form1(ITodoRepository repo, CreateTodoItem create, MarkTodoItemAsDone markDone)
        {
            InitializeComponent();
            _repo = repo;
            _create = create;
            _markDone = markDone;
            RefreshTodos();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _create.Execute(txtTitle.Text);
            RefreshTodos();
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            if (lstToDos.SelectedItem is TodoItem item)
            {
                _markDone.Execute(item.Id);
                RefreshTodos();
            }
        }

        private void RefreshTodos()
        {
            lstToDos.Items.Clear();
            foreach (var item in _repo.GetAll())
            {
                lstToDos.Items.Add(item);
            }
        }
    }
}
