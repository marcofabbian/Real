using System.Collections.Generic;
using System.Linq;
using Common.DomainModel;
using Real.DomainModel;

namespace Real.DomainServices.PropertyRepository
{
    public static class DbInitializer
    {
        public static void Initialize(PropertyContext context)
        {

            if (!context.Database.EnsureCreated())
                return;

            if (context.Properties.Any())
            {
                return; // DB has been seeded
            }


            var properties =
                new List<Property>()
                {
                    new Property(1,
                        new Address(1, "Zurich", "44", "Zurich", "Europa strasse", "Switzerland", "8016"),
                        DomainModel.Type.Apartment,
                        1,
                        1,
                        1000,
                        100,
                        2000,
                        1),

                    new Property(2,
                        new Address(2, "Bern", "77", "Bern", "Germania strasse", "Switzerland", "5009"),
                        DomainModel.Type.House,
                        2,
                        2,
                        2000,
                        200,
                        2000,
                        3),

                    new Property(3,
                        new Address(3, "Gevena", "77", "Geneva", "Rue des Vieux-Grenadiers", "Switzerland", "1009"),
                        DomainModel.Type.House,
                        3,
                        3,
                        3000,
                        300,
                        2000,
                        3)
                };

            context.Properties.AddRange(properties);
            context.SaveChanges();
        }
    }
}