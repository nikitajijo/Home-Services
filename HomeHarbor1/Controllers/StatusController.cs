using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Feedback;
using HomeHarbor1.Services_Status;
using HomeHarbor1.Aspects;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService service;

        public StatusController(IStatusService service)
        {
            this.service = service;
        }

        // GET: api/Bookings
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetStatus());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetStatus(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Status status)
        {
            return Ok(service.UpdateStatus(id, status));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Status status)
        {
            return StatusCode(201, service.AddStatus(status));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteStatus(id));
        }


    }
}
