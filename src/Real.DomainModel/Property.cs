using System;
using Common.DomainModel;

namespace Real.DomainModel
{
    public class Property
    {

        public Property(Guid? id, Address address, Type type, int room, int bath, float price, float space, int year, int floor)
        {
            if (!id.HasValue)
            {
                id = new Guid();
            }

            Id = id.Value;
            Address = address;
            Type = type;
            Room = room;
            Bath = bath;
            Price = price;
            Space = space;
            Year = year;
            Floor = floor;
        }

        public Property(Address address, Type type, int room, int bath, float price, float space, int year, int floor) : this(null, address, type, room, bath, price, space, year, floor)
        {
            ;
        }

        protected Guid Id { get; set; }
        protected Address Address { get; set; }
        protected Type Type { get; set; }
        protected int Room { get; set; }
        protected int Bath { get; set; }
        protected float Price { get; set; }
        protected float Space { get; set; }
        protected int Year { get; set; }
        protected int Floor { get; set; }
    }
}
