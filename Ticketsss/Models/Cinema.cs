using System.ComponentModel.DataAnnotations;

namespace Ticketsss.Models
{
        public class Cinema
        {
            [Key] public int CinemaId { get; set; }
            [Required] public string Name { get; set; }
            [Required] public string Description { get; set; }
            [Required] public string LogoImgURL { get; set; }

            // Relations
            public ICollection<Movie> Movies { get; set; }
        }
}
