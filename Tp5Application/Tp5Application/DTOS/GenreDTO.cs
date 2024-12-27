using System.ComponentModel.DataAnnotations;

namespace Tp5Application.DTOS
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
