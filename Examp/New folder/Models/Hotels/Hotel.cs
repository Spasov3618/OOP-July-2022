using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BookingApp.Repositories;

namespace BookingApp.Models.Hotels
{
    public class Hotel : IHotel
    {
        private string name;
        private int category;
        
       

       

        public Hotel(string name, int category)
        {
            this.FullName = name;
            this.Category = category;
            Rooms = new RoomRepository();
            Bookings = new BookingRepository();
            

           
        }

        public string FullName
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.HotelNameNullOrEmpty);
                }
                name = value; }
        }


        public int Category
        {
              get { return category; }  
            private set
            {
                if (value<1 && value>5)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCategory);
                }
                category = value; 
            }
        }

        public double Turnover => Math.Round(Bookings.All().Sum(x => x.ResidenceDuration * x.Room.PricePerNight), 2);

        public IRepository<IRoom> Rooms
        {
            get
            {
                return Rooms;
            }
            set
            {
                Rooms = value;
            }
        }
        public IRepository<IBooking> Bookings
        {
            get
            {
                return Bookings;
            }
             set
            {
                Bookings = value;
            }
        }
    }
}
