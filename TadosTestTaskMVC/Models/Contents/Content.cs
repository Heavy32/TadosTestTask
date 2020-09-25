using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TadosTestTask.Models.Contents
{
    public abstract class Content
    {
        [Required]        
        public int Id { get; set; }
        [Required]
        [DataType("nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int ContentTypeId { get; set; }
        public ContentType ContentType { get; set; }

        public List<UsersRating> UsersRatings { get; set; }
    }
}
