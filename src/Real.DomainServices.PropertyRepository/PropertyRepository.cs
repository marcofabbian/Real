using System;
using Microsoft.EntityFrameworkCore;
using Real.DomainModel;
using System.Collections.Generic;
using System.Linq;
using Common.DomainModel;

namespace Real.DomainServices.PropertyRepository
{
    public class PropertyRepository : IPropertyRepository
    {

        private readonly PropertyContext Context;

        public PropertyRepository(PropertyContext context)
        {
            this.Context = context;
            DbInitializer.Initialize(context);
        }

        public Property Get(int id)
        {
            return 
                Context.Properties
                    .Include(x => x.Address)
                    .FirstOrDefault(x=>x.Id == id);
        }

        public IList<Property> GetList()
        {
            return Context.Properties
                .Include(x=>x.Address)
                .ToList();
        }

        public bool Set(Property property)
        {
            try
            {
                Context.Properties
                    .Add(property);
                return Context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
