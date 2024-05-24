using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Booking;
using HomeHarbor1.Services_Feedback;
using HomeHarbor1.Aspects;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService service;

        public FeedbacksController(IFeedbackService service)
        {
            this.service = service;
        }

        // GET: api/Bookings
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetFeedback());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetFeedback(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Feedback feedback)
        {
            return Ok(service.UpdateFeedback(id, feedback));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Feedback feedback)
        {
            return StatusCode(201, service.AddFeedback(feedback));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteFeedback(id));
        }


    }
}
