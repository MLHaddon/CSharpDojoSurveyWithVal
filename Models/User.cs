using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithVal.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name {get; set;}

        [Required]
        public string DojoLocation {get; set;}

        [Required]
        public string Language {get; set;}

        [MaxLength(20)]
        public string Comment {get; set;}
    }
}