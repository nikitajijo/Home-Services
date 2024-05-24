using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Registration;
using HomeHarbor1.Services_Service;
using HomeHarbor1.Aspects;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService service;

        public ServicesController(IServiceService service)
        {
            this.service = service;
        }

        //GET: api/Bookings
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetService());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetService(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[Authorize(Roles = "Admin")]
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Service services)
        {
            return Ok(service.UpdateService(id, services));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post(Service services)
        {
            return StatusCode(201, service.AddService(services));
        }

        // DELETE: api/Bookings/5
        //[Authorize(Roles = "Admin")]
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteService(id));
        }
        //[HttpGet]
        //[Route("{service}")]
        //public IActionResult Get(string services)
        //{
        //    return Ok(service.SearchServices(services));
        //}
        
        [HttpGet]

        [Route("{services}/name")]

        public IActionResult Get(string services)

        {

            return Ok(service.SearchServices(services));

        }

    }
}
