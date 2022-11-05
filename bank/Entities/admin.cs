using System.ComponentModel.DataAnnotations;

namespace bank.Entities
{
    public class admin
    {
        [Required]
        public string userid { get; set; }
        [Required]
        public string password { get; set; }
    }
}
