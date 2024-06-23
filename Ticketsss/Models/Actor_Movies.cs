﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketsss.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
    }
}
