using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "first name is required or name is too long"), MaxLength(50)]
        public string firstName { get; set; }
        [Required(ErrorMessage = "second name is required or name is too long"), MaxLength(50)]
        public string secondName { get; set; }
        [Required(ErrorMessage ="age is required ")]
        public int age { get; set; }
        [Required(ErrorMessage = "country name is required or name is too long"), MaxLength(50)]
        public string country { get; set; }
        [Required(ErrorMessage ="city name is required or name is too long"), MaxLength(50)]
        public string city { get; set; }
    }
}
