using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieRental.Models
{
    public class NewRental
    {
        public int customerId { get; set; }
        public List<int> movieIds { get; set; }

    }
}
