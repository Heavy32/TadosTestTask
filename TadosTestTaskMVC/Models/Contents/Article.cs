using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadosTestTask.Models.Contents
{
    public class Article : Content
    {
        [DataType(DataType.Text)]
        public string Text { get; set; }
    }
}
