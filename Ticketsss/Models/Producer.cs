using eTickets.Models;
using System.ComponentModel.DataAnnotations;

namespace Ticketsss.Models
{
    public class Producer
    {
        [Key] public int ProducerId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Biography { get; set; }
        [Required] public string ProfilePicURL { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
