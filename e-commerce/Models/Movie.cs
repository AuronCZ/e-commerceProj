using e_commerce.Data.Enoms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Movie
    {

        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Descritption { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateAndTime StartDate { get; set; }
        public DateAndTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }


    }
}
