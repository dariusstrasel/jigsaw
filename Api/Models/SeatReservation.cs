namespace Api.Models
{
    public class SeatReservation
    {
        public string SeatId { get; set; }
        public Seat Seat { get; set; }
        public string ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}