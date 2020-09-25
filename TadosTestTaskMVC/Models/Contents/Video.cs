using System.ComponentModel.DataAnnotations;

namespace TadosTestTask.Models.Contents
{
    public class Video : Content
    {
        [DataType(DataType.Url)]
        public string URL { get; set; }
    }
}
