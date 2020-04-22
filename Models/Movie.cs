using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Category { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public int Rating { get; set; }
    }
}
