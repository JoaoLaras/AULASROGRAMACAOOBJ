using System;
using ExercExcTratadas.Entities.Exceptions;

namespace Course.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExceptions("Check -out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainExceptions("dates for update must be futures dates");
            }

            if (checkout <= checkin)
            {
                throw new DomainExceptions("Check -out date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nigths";
        }
    }

}
