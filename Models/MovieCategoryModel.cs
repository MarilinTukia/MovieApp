using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieCategoryModel
    {
        public List<Movie> Movies { get; set; }

        public SelectList Categories { get; set; }

        public String MovieCategory { get; set; }

        public String SearchString { get; set; }

    }
}
