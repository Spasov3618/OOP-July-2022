using FrontDeskApp;
using NUnit.Framework;
using System;

namespace BookigApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void TestCtorBooking()
        {
            Room room = new Room(5, 20);
            Booking booking = new Booking(1, room, 5);

            Assert.AreEqual(booking.BookingNumber, 1);
            Assert.AreEqual(booking.Room, room);
            Assert.AreEqual(booking.ResidenceDuration, 5);
        }
        [Test]
        public void TestCtorHotel()
        {
            Hotel hotel = new Hotel("Sofia", 4);
            Assert.AreEqual(hotel.FullName, "Sofia");
            Assert.AreEqual(hotel.Category, 4);

        }
        [Test]
        public void ThrowNameNuul()
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(null, 2));
            Assert.Throws<ArgumentNullException>(() => new Hotel(String.Empty, 2));


        }
        [Test]
        public void ThrowCategory()
        {
            Assert.Throws<ArgumentException>(() => new Hotel("bla", 0));
            Assert.Throws<ArgumentException>(() => new Hotel("ha", 6));
        }
        [Test]
        public void TestTurnOver()
        {
            Hotel hotel = new Hotel("Sofia", 4);
            var rezult = hotel.Turnover;
            Assert.AreEqual(0, rezult);
        }
        [Test]
        public void AddRoom()
        {
            Room room = new Room(10, 20);
            Hotel hotel = new Hotel("Sofia", 5);
            hotel.AddRoom(room);
            Assert.AreEqual(hotel.Rooms.Count, 1);
        }
        [Test]
        public void ThrowBookRoom()
        {
            Hotel hotel = new Hotel("Sofia", 4);
            Room room = new Room(20, 30);
            hotel.AddRoom(room);
            hotel.BookRoom(2, 1, 3, 20);
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(0, 1, 3, 20));
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(1, -1, 3, 20));
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(1, 1, 0, 20));
        }
        [Test]
        public void BookRoom_NoBookingForNotEnoughBeds()
        {
            var hotel = new Hotel("HotelName", 5);
            var room = new Room(3, 53);
            hotel.AddRoom(room);

            hotel.BookRoom(4, 1, 2, 200);

            Assert.That(hotel.Turnover.Equals(0));
        }

        [Test]
        public void BookRoom_WorksProperly()
        {
            var hotel = new Hotel("HotelName", 5);
            var room = new Room(5, 53);
            hotel.AddRoom(room);

            hotel.BookRoom(4, 1, 2, 106);
            double expectedTurnover = 106;

            Assert.AreEqual(expectedTurnover, hotel.Turnover);
            Assert.That(hotel.Bookings.Count.Equals(1));
            Assert.That(hotel.Rooms.Count.Equals(1));
        }

        [Test]
        public void BookRoom_NoBookingIfTooLowBudget()
        {
            var hotel = new Hotel("HotelName", 5);
            var room = new Room(5, 53);
            hotel.AddRoom(room);

            hotel.BookRoom(4, 1, 2, 100);
            double expectedTurnover = 0;

            Assert.AreEqual(expectedTurnover, hotel.Turnover);
            Assert.That(hotel.Bookings.Count.Equals(0));
            Assert.That(hotel.Rooms.Count.Equals(1));
        }
    }
}