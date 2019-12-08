using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMovieRental.Models;

namespace OnlineMovieRental.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewRentalsController : ControllerBase
    {
        private VirtualDB _context;

    
        public NewRentalsController(VirtualDB context)
        {
            _context = context;    
        }


        [HttpPost]
        public IActionResult CreateNewRentals([FromForm] NewRental newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.customerId);

            var movies = _context.Movies.Where(
                m => newRental.movieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}