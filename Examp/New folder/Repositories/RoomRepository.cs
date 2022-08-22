using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Repositories
{
    public class RoomRepository : IRepository<IRoom>
    {
        private List<IRoom> room;

        public RoomRepository()
        {
            room = new List<IRoom>();
        }

        public void AddNew(IRoom model)
        {
            room.Add(model);
        }

        public IReadOnlyCollection<IRoom> All()
        {
           
                return room.AsReadOnly();
          
        }

        public IRoom Select(string criteria)
        {
            return room.FirstOrDefault(x => x.GetType().Name == criteria);
        }
    }
}
