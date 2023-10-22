using System.ComponentModel.DataAnnotations;

namespace EFConfigureExample.DTOs
{
    public class UserCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
