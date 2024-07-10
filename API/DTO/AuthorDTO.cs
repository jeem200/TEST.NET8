using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class AuthorDTO
    {
        [Required]
        [MaxLength(40, ErrorMessage = "Cannot be over $0 over characters")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Cannot be over 10 over characters")]
        public string Job { get; set; } = string.Empty;

    }
}
