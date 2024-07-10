namespace API.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Job { get; set; } = string.Empty;

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
