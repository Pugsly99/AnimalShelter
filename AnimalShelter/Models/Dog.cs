using System.ComponentModel.DataAnnotations;
namespace AnimalShelter.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "Age must be between 1 and 99.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}