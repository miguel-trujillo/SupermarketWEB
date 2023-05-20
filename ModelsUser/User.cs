using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.ModelsUser
{
    public class User
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)] 
        public string Password { get; set; }
    }
}
