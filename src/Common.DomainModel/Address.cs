using System;

namespace Common.DomainModel
{
    public class Address
    {
        public int Id { get; set; }
        public string Road { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


        public Address() { }

        public Address(int id, string city, string number, string region, string road, string state, string zipcode)
        {
            this.Id = id;
            this.City = city;
            this.Number = number;
            this.Region = region;
            this.Road = road;
            this.State = state;
            this.ZipCode = zipcode;
        }

    }
}
