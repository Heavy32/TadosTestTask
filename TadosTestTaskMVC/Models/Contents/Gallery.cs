using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TadosTestTask.Models.Contents
{
    public class Gallery : Content
    {
        public ICollection<Photo> PhotosURLs { get; set; }
        [Required]
        [StringLength(100)]
        public string CoverPath { get; set; }
    }
}
