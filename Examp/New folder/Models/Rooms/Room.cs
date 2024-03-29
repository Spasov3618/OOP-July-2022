﻿using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        
        private double pricePerNight =0;
        private int bedCapacity;

        protected Room(int  bedCapacity)
        {
            this.bedCapacity = bedCapacity;
            this.PricePerNight = pricePerNight;
        }
        public int BedCapacity => bedCapacity;

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
            pricePerNight = price;
        }
    }
}
