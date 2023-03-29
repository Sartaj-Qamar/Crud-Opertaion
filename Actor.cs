using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureUrl{ get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 to 50 chars")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set;}
    }
}
