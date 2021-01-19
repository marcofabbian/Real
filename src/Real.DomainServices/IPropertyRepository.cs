using System;
using System.Collections.Generic;
using Real.DomainModel;

namespace Real.DomainServices
{
    public interface IPropertyRepository
    {
        public Property Get(int id);

        public IList<Property> GetList();

        public bool Set(Property property);
    }
}
