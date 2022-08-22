using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Repositories
{
    public class HotelRepository : IRepository<IHotel>
    {
        public List<IHotel> hotel;

        public HotelRepository()
        {
            hotel = new List<IHotel>();
        }
        public void AddNew(IHotel model)
        {
            hotel.Add(model);
        }

        public IReadOnlyCollection<IHotel> All()
        {
            return hotel.AsReadOnly();
        }

        public IHotel Select(string criteria)
        {
            return hotel.FirstOrDefault(x =>x.GetType().Name == criteria);
        }
    }
}
