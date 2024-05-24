using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Booking;
using HomeHarbor1.Aspects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    [EnableCors("policy")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService service;

        public BookingsController(IBookingService service)
        {
            this.service=service;
        }

        // GET: api/Bookings
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult Get()
        {
            return Ok(service.GetBooking());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetBooking(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Booking booking)
        {
            return Ok(service.UpdateBooking(id,booking));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Booking booking)
        {
            return StatusCode(201, service.AddBooking(booking));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteBooking(id));
        }

        
    }
}
