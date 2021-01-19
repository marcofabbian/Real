using System;
using System.Collections;
using System.Collections.Generic;
using Common.DomainModel;
using NUnit.Framework;
using Moq;
using Real.DomainModel;

namespace Real.DomainServices.UnitTests
{

    /// Test methods naming convention
    ///     When_StateUnderTest_Expect_ExpectedBehavior
    /// 
    ///         o When_AgeLessThan18_Expect_isAdultAsFalse
    ///         o When_InvalidAccount_Expect_WithdrawMoneyToFail
    ///         o When_MandatoryFieldsAreMissing_Expect_StudentAdmissionToFail


    public class RealPropertyRepositoryUnitTests
    {
        private int Id1 = 1;
        private Property property1;

        private int Id2 = 2;
        private Property property2;

        private IList<Property> properties;
        private Mock<IPropertyRepository> mock;
        private IPropertyRepository repository;

        [SetUp]
        public void Setup()
        {
            var address1 = new Address(1, "Zurich", "44", "Zurich", "Europa strasse", "Switzerland", "8016");

            var address2 = new Address(2, "Bern", "77", "Bern", "Germania strasse", "Switzerland", "5009");

            property1 = new Property(Id1, address1, DomainModel.Type.Apartment, 2, 2, 2000, 200, 2000, 1);
            property2 = new Property(Id2, address2, DomainModel.Type.House, 2, 2, 2000, 200, 2000, 3);

            properties = new List<Property>()
            {
                property1,
                property2
            };

            mock = new Mock<IPropertyRepository>();
            mock
                .Setup(x => x.Get(Id1))
                .Returns(property1);
            mock
                .Setup(x => x.Get(Id2))
                .Returns(property2);

            mock
                .Setup(x => x.GetList())
                .Returns(properties);

            repository = mock.Object;
        }

        [Test]
        public void When_GetPropertyById_Expect_ValidRealEstate()
        {
            var result = repository.Get(Id1);

            Assert.IsNotNull(result);
        }

        [Test]
        public void When_GetAll_Expect_AllValidRealEstate()
        {
            var results = repository.GetList();

            Assert.IsTrue(results is IList);
            Assert.IsTrue(results.Count == 2);
        }
    }
}