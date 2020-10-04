using Microsoft.AspNetCore.Http;

namespace WebApplication.DTOs
{
    public class TodoItemUpdateDto
    {
        public string Line { get; set; }
        public string Status { get; set; }

        public void SetValues(IFormCollection data)
        {
            Line = data["line"];
            Status = data["status"];
        }
    }
}