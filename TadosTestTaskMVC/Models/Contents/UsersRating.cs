using System.ComponentModel.DataAnnotations;

namespace TadosTestTask.Models.Contents
{
    public class UsersRating
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ContentId { get; set; }
        public Content Content { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
    }
}
