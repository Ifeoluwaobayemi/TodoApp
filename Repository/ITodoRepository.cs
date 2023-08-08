using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Repository
{
    public interface ITodoRepository
    {
        Task<List<TodoItem>> GetAllTodoItems();
        Task<TodoItem> AddTodo(TodoItem todoItem);
        Task<TodoItem> Update(TodoItem todoItem);
        void Delete(Guid id);

        Task<TodoItem> Get(Guid id);
    }
}
