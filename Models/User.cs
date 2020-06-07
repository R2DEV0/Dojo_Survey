using System.ComponentModel.DataAnnotations;
namespace Dojo_survey.Models
{
    public class Person
    {
        [Required(ErrorMessage="This is required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        [Display(Name = "Name: ")]
        public string Name {get; set;}



        [Required(ErrorMessage="This is required")]
        [Display(Name = "Location: ")]
        public string Location{get; set;}



        [Required(ErrorMessage="This is required")]
        [Display(Name = "Language: ")]
        public string Language{get; set;}


        [MinLength(20, ErrorMessage="Comment must be at least 20 characters")]
        [Display(Name = "Comment: ")]
        public string Comment{get; set;}
    }
}