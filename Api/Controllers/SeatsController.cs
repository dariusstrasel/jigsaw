using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        [HttpGet]
        // GET api/seat
        public ActionResult<IEnumerable<Seat>> Get()
        {
            var seats = new List<Seat>()
            {
                new Seat()
                {
                }
            };
            return seats;
        }

        [HttpGet("{id}")]
        public ActionResult<Seat> Get(string id)
        {
            return new Seat() {  };
        }
    }
}
