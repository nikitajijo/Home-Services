using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeHarbor1.Models;
using HomeHarbor1.Services_Registration;
using HomeHarbor1.Services_Slot;
using HomeHarbor1.Aspects;
using Microsoft.AspNetCore.Authorization;

namespace HomeHarbor1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class SlotsController : ControllerBase
    {
        private readonly ISlotService service;

        public SlotsController(ISlotService service)
        {
            this.service = service;
        }

        // GET: api/Bookings
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetSlot());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSlot(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Put(int id, Slot slot)
        {
            return Ok(service.UpdateSlot(id, slot));
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public IActionResult Post(Slot slot)
        {
            return StatusCode(201, service.AddSlot(slot));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        //[Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteSlot(id));
        }


    }
}
