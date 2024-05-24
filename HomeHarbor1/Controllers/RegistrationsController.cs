using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Booking;
using HomeHarbor1.Services_Registration;
using HomeHarbor1.Aspects;
using Microsoft.AspNetCore.Authorization;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class RegistrationsController : ControllerBase
    {
        private readonly IRegistrationService service;

        public RegistrationsController(IRegistrationService service)
        {
            this.service = service;
        }

        // GET: api/Bookings
        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public IActionResult Get()
        {
            return Ok(service.GetRegistration());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetRegistration(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Registration registration)
        {
            return Ok(service.UpdateRegistration(id, registration));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Registration registration)
        {
            return StatusCode(201, service.AddRegistration(registration));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteRegistration(id));
        }
        [HttpPost("login")]
        public string Login(string email, string password)
        {
            var result = service.Login(email, password);

            if (result != null)
            {
                return result;
            }
            return null;
        }


    }
}
