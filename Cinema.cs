using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display (Name = "Discription")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
