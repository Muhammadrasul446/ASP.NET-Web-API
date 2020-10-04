using AutoMapper;
using WebApplication.DTOs;
using WebApplication.Models;

namespace WebApplication.Profiles
{
    public class TodoItemsProfile : Profile
    {
        public TodoItemsProfile()
        {
            CreateMap<TodoItemCreateDto, TodoItem>();
            CreateMap<TodoItemUpdateDto, TodoItem>();
        }
    }
}