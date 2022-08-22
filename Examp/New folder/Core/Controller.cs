using BookingApp.Core.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BookingApp.Models.Hotels;
using BookingApp.Utilities.Messages;
using BookingApp.Models.Rooms;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        HotelRepository hotels;
        RoomRepository rooms;

        public Controller()
        {
            hotels = new HotelRepository(); 
            rooms = new RoomRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            

            if (hotels.GetType().Name == hotelName)
            {
               return String.Format(OutputMessages.HotelAlreadyRegistered, hotelName);
            }
            Hotel hotel = new Hotel(hotelName, category);
            hotels.AddNew(hotel);
            return String.Format(OutputMessages.HotelSuccessfullyRegistered,hotelName,category);

            
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            throw new NotImplementedException();
        }

        public string HotelReport(string hotelName)
        {
            throw new NotImplementedException();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            throw new NotImplementedException();
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName )
        {
            if (hotels.GetType().Name != hotelName)
            {
                return String.Format(OutputMessages.HotelNameInvalid, hotelName);
            }
            if (hotels.GetType().Name == roomTypeName)
            {
                return String.Format(OutputMessages.RoomTypeAlreadyCreated);
            }
            Room room;
            if (roomTypeName == nameof(Apartment))
            {
                room = new Apartment();
            }
            else if (roomTypeName == nameof(DoubleBed))
            {
                room = new DoubleBed();
            }
            else if (roomTypeName == nameof(Studio))
            {
                room = new Studio();
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            rooms.AddNew(room);
            return String.Format(OutputMessages.RoomTypeAdded, roomTypeName, hotelName);
            
        }
    }
}
