using System;
using Entities.Execeptions;

namespace Entities.Class143
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExcepetion("Check-out date must be after check-in date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan diff = CheckOut.Subtract(CheckIn);
            return diff.Days;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainExcepetion("Reservation dates for update must bem future dates!");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainExcepetion("Check-out date must be after check-in date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", Check-in: "
                + CheckIn.ToString()
                + ", Check-out: "
                + CheckOut.ToString()
                + ", "
                + Duration()
                + " nights.";
        }
    }
}