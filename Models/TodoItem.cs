using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Status { get; set; }
    }
}