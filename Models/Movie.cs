using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime RelaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
       


    }
}
