using System.ComponentModel.DataAnnotations.Schema;

namespace notesAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Note { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now; 
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.Now; 

        [ForeignKey("UserId")]
        public string? UserId { get; set; }

        public User? User { get; set; }
    }
}
