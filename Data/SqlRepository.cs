using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class SqlRepository : IRepository
    {
        private readonly ApiContext _context;

        public SqlRepository(ApiContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<TodoItem> GetAllTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetTodoItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(p => p.Id == id);
        }

        public void CreateTodoItem(TodoItem todoItem)
        {
            if (todoItem == null) throw new ArgumentNullException(nameof(todoItem));

            _context.TodoItems.Add(todoItem);
        }

        public void UpdateTodoItem(TodoItem todoItem)
        {
            // Nothing
        }
    }
}