using Real.DomainModel;
using System;
using System.Collections.Generic;
using Common.DomainModel;

namespace Real.DomainServices.PropertyRepository
{
    public class PropertyRepository : IPropertyRepository
    {
        public Property Get(Guid id)
        {
            return new Property(Guid.NewGuid(),
                new Address("Zurich", "44", "Zurich", "Europa strasse", "Switzerland", "8016"),
                DomainModel.Type.Apartment,
                2,
                2,
                2000,
                200,
                2000,
                1);
        }

        public IList<Property> GetList()
        {
            return
                new List<Property>()
                {
                    new Property(Guid.NewGuid(),
                        new Address("Zurich", "44", "Zurich", "Europa strasse", "Switzerland", "8016"),
                        DomainModel.Type.Apartment,
                        2,
                        2,
                        2000,
                        200,
                        2000,
                        1),
                    new Property(Guid.NewGuid(),
                        new Address("Bern", "77", "Bern", "Germania strasse", "Switzerland", "5009"),
                    DomainModel.Type.House,
                    2,
                    2,
                    2000,
                    200,
                    2000,
                    3)
                };
        }

        public bool Set(Property property)
        {
            return true;
        }
    }
}
