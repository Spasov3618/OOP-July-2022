using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        private const double StartPricePerNight = 0;
        private double pricePerNight;

        public Room(int  bedCapacity)
        {
            this.BedCapacity = bedCapacity;
            this.PricePerNight = pricePerNight;
        }
        public int BedCapacity {get; protected set;}

        public double PricePerNight
        {
            get { return PricePerNight; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);
                }
                PricePerNight = value;
            }

        }

        public void SetPrice(double price)
        {
            pricePerNight = StartPricePerNight;
        }
    }
}
