using System;

namespace Api.Models
{
    public class Reservation
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string ReservationId { get; set; }
    }
}