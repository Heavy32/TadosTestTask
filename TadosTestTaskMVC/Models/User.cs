using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TadosTestTask.Models.Contents;

namespace TadosTestTask
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Login { get; set; }
        [DataType("varchar(100)")]
        public string City { get; set; }

        public List<Content> Contents { get; set; }

        public List<UsersRating> UsersRatings { get; set; }
    }
}
