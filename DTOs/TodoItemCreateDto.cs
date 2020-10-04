using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication.DTOs
{
    public class TodoItemCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
        [Required]
        [MaxLength(250)]
        public string Status { get; set; }

        public TodoItemCreateDto(IFormCollection data)
        {
            Line = data["line"];
            Status = data["status"];
        }
    }
}