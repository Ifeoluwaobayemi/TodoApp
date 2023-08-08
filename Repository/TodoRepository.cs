using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp.Repository
{

    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _context;

        public List<TodoItem> todoItems = new List<TodoItem>();
        
        public TodoRepository(TodoDbContext context) 
        {  
            _context = context; 
        }
        public async Task<TodoItem> AddTodo(TodoItem TodoItems)
        {
            todoItems.Add(TodoItems);

            //await _context.TodoItems.AddAsync(TodoItems);
            _context.data.Add(todoItems);
            //_context.SaveChanges();
            return TodoItems;
        }

        public void Delete(Guid id)
        {
          var taskToDelete = _context.TodoItems.FirstOrDefault(t => t.Id == id); 
            if (taskToDelete != null)
            {
                _context.TodoItems.Remove(taskToDelete); 
                _context.SaveChanges();
            }
        }

        public async Task<TodoItem> Get(Guid id)
        {
            return await _context.TodoItems.FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<List<TodoItem>> GetAllTodoItems(TodoItem TodoItems, DataGridView dataGridView)
        {
            var todo = _context.data;
            dataGridView.DataSource = todo;
            return todoItems;
        }

        public Task<List<TodoItem>> GetAllTodoItems()
        {
            throw new NotImplementedException();
        }

        public async Task<TodoItem> Update(TodoItem TodoItems)
        {
            var todo = await _context.TodoItems.Where(x => x.Id == TodoItems.Id).FirstOrDefaultAsync();
            todo.Title = TodoItems.Title;
            todo.Description = TodoItems.Description;

            _context.SaveChanges();
            return TodoItems;
        }
    }
}
