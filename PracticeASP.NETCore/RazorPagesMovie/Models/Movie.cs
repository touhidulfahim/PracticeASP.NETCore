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
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        
        [Display(Name ="RELEASE DATE")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="GENRE")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [Display(Name ="PRICE")]
        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name ="RATING")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }
    }
}
