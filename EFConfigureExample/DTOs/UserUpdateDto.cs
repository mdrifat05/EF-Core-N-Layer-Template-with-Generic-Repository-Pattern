using System.ComponentModel.DataAnnotations;

namespace EFConfigureExample.DTOs
{
    public class UserUpdateDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
