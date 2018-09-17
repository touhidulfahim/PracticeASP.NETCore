using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie
{
    public class Movie
    {
        
        
        public int ID { get; set; }

        [Display(Name ="MOVIE TITLE")]
        public string Title { get; set; }
        
        [Display(Name ="RELEASE DATE")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
