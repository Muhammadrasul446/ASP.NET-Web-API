using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication.DTOs
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; }
        
        [Required]
        public string Platform { get; set; }

        public void SetValues(IFormCollection data)
        {
            HowTo = data["how_to"];
            Line = data["line"];
            Platform = data["platform"];
        }
    }
}