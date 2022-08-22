using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        private HashSet<IRoom> room;
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;
        private int bookingNumber;
        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            BookingNumber = bookingNumber;
            ChildrenCount = childrenCount;
            AdultsCount = adultsCount;
            ResidenceDuration = residenceDuration;
            Room = room;
        }

        public IRoom Room { get; }

        public int ResidenceDuration
        {
            get { return residenceDuration; }
            set 
            {
                if (value<1)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }    
                residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get { return adultsCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }
                adultsCount = value;
            }
        }
        public int ChildrenCount
        { 
            get { return childrenCount; }
    set
            {
                if (value< 0)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
}
                childrenCount = value;
            }
        }

        public int BookingNumber
        {
            get => bookingNumber;
            private set
            {
                bookingNumber = value;
            }
        }
        public string BookingSummary()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Booking number: {BookingNumber}");
            sb.AppendLine($"Room type: {room.GetType().Name}");
            sb.AppendLine($"Adults: {AdultsCount} Children: {ChildrenCount}");
            var TotalPaid = Math.Round(residenceDuration*Room.PricePerNight,2);
            sb.AppendLine($"Total amount paid: {TotalPaid} $");

            return sb.ToString().TrimEnd();
        }
    }
}
