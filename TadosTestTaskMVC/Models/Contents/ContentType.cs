using System.ComponentModel.DataAnnotations;

namespace TadosTestTask.Models.Contents
{
    public class ContentType
    {
        [Required]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}
