using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.DTOs;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/todo_items"), ApiController]
    public class TodoItemsController : Controller
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        // Constructor
        public TodoItemsController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        // GET api/todo_items
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAllTodoItems()
        {
            var todoItems = _repository.GetAllTodoItems();
            return Ok(todoItems);
        }
        
        // GET api/todo_items/{id}
        [HttpGet("{id}", Name = "GetTodoItemById")]
        public ActionResult<TodoItem> GetTodoItemById(int id)
        {
            var todoItem = _repository.GetTodoItemById(id);
            
            if (todoItem == null) return NotFound();
            
            return Ok(todoItem);
        }
        
        // POST api/todo_items
        [HttpPost]
        public ActionResult<TodoItem> CreateTodoItem(IFormCollection data)
        {
            var todoItemCreateDto = new TodoItemCreateDto(data);
            var todoItemModel = _mapper.Map<TodoItem>(todoItemCreateDto);
            _repository.CreateTodoItem(todoItemModel);
            _repository.SaveChanges();

            return CreatedAtRoute(nameof(GetTodoItemById), new {Id = todoItemModel.Id}, todoItemModel);
        }
        
        // PUT api/todo_items/{id}
        [HttpPut("{id}")]
        public ActionResult<TodoItem> UpdateTodoItem(int id, IFormCollection data)
        {
            var todoItemModelFromRepo = _repository.GetTodoItemById(id);

            if (todoItemModelFromRepo == null) return NotFound();
            
            var todoItemUpdateDto = new TodoItemUpdateDto();
            todoItemUpdateDto.SetValues(data);

            _mapper.Map(todoItemUpdateDto, todoItemModelFromRepo);
            _repository.UpdateTodoItem(todoItemModelFromRepo);
            _repository.SaveChanges();

            return Ok(todoItemModelFromRepo);
        }
    }
}