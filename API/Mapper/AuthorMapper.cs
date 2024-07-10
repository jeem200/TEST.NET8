using API.DTO;
using API.Models;

namespace API.Mapper
{
    public static class AuthorMapper
    {
        public static Author ToAuthorFromDTO(this AuthorDTO authorDto)
        {
            return new Author
            {
                Name = authorDto.Name,
                Job = authorDto.Job,

            };
        }
    }
}
