using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Windows.Forms;
using TodoApp.Repository;

namespace TodoApp
{
    public partial class TodoApp : Form
    {
        TodoDbContext todoDb;
        List<TodoItem> todoItem;
        //private readonly ITodoRepository _repository;
        //private TodoDbContext dbContext;
        public TodoApp()
        {
            todoDb = new TodoDbContext();
            InitializeComponent();
            //_repository = repository;
            //dbContext = new InMemoryTodoDbContext();

            ShowTodoList();
        }

        private void ShowTodoList()
        {
            todoItem = todoDb.TodoItems.Select(t => t).ToList();
            todoListView.DataSource = "";


            foreach (TodoItem item in todoItems)
            {
                todoListView.DataSource = item.ToString();

            }
        }

        List<TodoItem> todoItems = new List<TodoItem>();

        //DataTable todoList = new DataTable();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public void Display()
        //{
        //    TodoItem tasks = new TodoItem();
        //    var todo = _repository.GetAllTodos();
        //}

        private void TodoAppForm_Shown(object sender, EventArgs e)
        {
            //Display();
        }
        private void titleLabel_Click(object sender, EventArgs e) { }

        private void descriptionLabel_Click(Object sender, EventArgs e) { }

        private void addButton_Click(Object sender, EventArgs e)
        {
            DateTime selectedDate = dueDateTime.Value;
            TodoItem newItem = new TodoItem
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                DueDate = selectedDate
            };

            try
            {
                todoDb.TodoItems.Add(newItem);
                todoDb.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            ShowTodoList();


            todoItems.Add(newItem);
            titleTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            dueDateTime.Value = DateTime.Now;

            RefreshDataGridView();



        }

        private void RefreshDataGridView()
        {
            todoListView.DataSource = null;
            todoListView.DataSource = todoItems;
            //todoListView.RowTemplate.Height = 30;

            foreach (DataGridViewRow row in todoListView.Rows)
            {
                row.Height = 70;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (todoListView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            

           // TodoItem todoItem = todoListView.SelectedRows[0].DataBoundItem as TodoItem;
           // todoItem.Title = titleTextBox.Text;
            //todoItem.Description = descriptionTextBox.Text;
            //todoItem.DueDate = DateTime.Now;

            bool isEditing = true;

            //List<TodoItem> editResult = todoItems.Where(item =>
            //       item.Title.Contains(todoItem.Title, StringComparison.OrdinalIgnoreCase) ||
            //       item.Description.Contains(todoItem.Description, StringComparison.OrdinalIgnoreCase) ||
            //      item.DueDate.ToShortDateString().Contains(todoItem.DueDate.ToShortDateString(), StringComparison.OrdinalIgnoreCase)
            //   ).ToList();
          
            TodoItem? editResult = todoListView.SelectedRows[0].DataBoundItem as TodoItem;
            TodoItem? editResulted = todoListView.SelectedRows[0].DataBoundItem as TodoItem;
            if (editResult != null &&  editResulted != null)
            {
                do
                {
                    todoDb.TodoItems.Remove(editResult);
                    todoDb.SaveChanges();

                } while (isEditing);
                isEditing = false;
                
                todoItems.Remove(editResult);
                todoItems.Add(editResulted);
                todoDb.TodoItems.Add(editResulted);
                todoDb.SaveChanges();
            }
            
           
            

          //  titleTextBox.Text = string.Empty;
           // descriptionTextBox.Text = string.Empty;
            //isEditing = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (todoListView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            TodoItem selectedItem = todoListView.SelectedRows[0].DataBoundItem as TodoItem;
            todoItems.Remove(selectedItem);
            todoDb.TodoItems.Remove(selectedItem);
            todoDb.SaveChanges();
            RefreshDataGridView();

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text;

            // Filter the todo items based on the search term
            List<TodoItem> searchResults = todoItems.Where(item =>
                item.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                item.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
               item.DueDate.ToShortDateString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            // Update the DataGridView with the search results
            todoListView.DataSource = null;
            todoListView.DataSource = searchResults;

            foreach (DataGridViewRow row in todoListView.Rows)
            {
                row.Height = 70;
            }
        }

        private void todoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}