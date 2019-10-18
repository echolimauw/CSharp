using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string FirstName {get;set;}

        [Required]
        [MinLength(3)]
        public string LastName {get;set;}

        [Required]
        [Range(13, 130)]
        public int Age {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}