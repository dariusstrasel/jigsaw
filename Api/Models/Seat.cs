using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Api.Models
{
    public class Seat
    {
        public string SeatId { get; set; }
        public bool Reservable { get; set; }
    }
}
