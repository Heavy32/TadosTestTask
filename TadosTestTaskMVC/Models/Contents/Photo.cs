using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadosTestTask.Models.Contents
{
    public class Photo
    {
        [Required]
        public int Id { get; set; }
        [DataType("varchar(100)")]
        public string Name { get; set; }
        [Required]
        [DataType("varchar(100)")]
        public string Path { get; set; }
    }
}
