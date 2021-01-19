using System;
using Common.DomainModel;

namespace Real.DomainModel
{
    public class Property
    {
        public Property()
        {
            ;
        }

        public Property(int id, Address address, Type type, int room, int bath, float price, float space, int year, int floor)
        {
            Id = id;
            Address = address;
            Type = type;
            Room = room;
            Bath = bath;
            Price = price;
            Space = space;
            Year = year;
            Floor = floor;
        }

        public int Id { get; set; }
        public Address Address { get; set; }
        public Type Type { get; set; }
        public int Room { get; set; }
        public int Bath { get; set; }
        public float Price { get; set; }
        public float Space { get; set; }
        public int Year { get; set; }
        public int Floor { get; set; }
    }
}
