using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface IRepository
    {
        bool SaveChanges();
        
        // TodoItems
        IEnumerable<TodoItem> GetAllTodoItems();
        TodoItem GetTodoItemById(int id);
        void CreateTodoItem(TodoItem todoItem);
        void UpdateTodoItem(TodoItem todoItem);
    }
}