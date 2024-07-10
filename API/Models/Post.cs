using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title  { get; set; } =string.Empty;

        public string Content   { get; set; }=string.Empty;

        [DefaultValue(0)]
        public int Count { get; set; }

        public int? AuthorID  { get; set; }

        public Author? Author { get; set; } 
    }
}
