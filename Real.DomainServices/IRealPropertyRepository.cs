using System;
using System.Collections.Generic;
using Real.DomainModel;

namespace Real.DomainServices
{
    public interface IRealPropertyRepository
    {
        public RealProperty Get(Guid id);

        public IList<RealProperty> GetList();

        public bool Set(RealProperty realProperty);
    }
}
