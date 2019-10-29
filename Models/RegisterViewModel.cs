using System.ComponentModel.DataAnnotations;

namespace FirstDotnetCoreMVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}