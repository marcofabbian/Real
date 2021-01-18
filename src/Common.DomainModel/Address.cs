using System;

namespace Common.DomainModel
{
    public class Address
    {
        protected string Road { get; set; }
        protected string Number { get; set; }
        protected string City { get; set; }
        protected string Region { get; set; }
        protected string State { get; set; }
        protected string ZipCode { get; set; }
        public Address(string city, string number, string region, string road, string state, string zipcode)
        {
            this.City = city;
            this.Number = number;
            this.Region = region;
            this.Road = road;
            this.State = state;
            this.ZipCode = zipcode;
        }

    }
}
