
using Domain;

namespace DomainTests
{
    public class CustomerEntityTests
    {
        [Fact]
        public void CustomerIsValid()
        {
            var customer = new Customer()
            {
                Name = "Test",
                Surname = "Test",
                CustomerDocument = new CustomerDocument()
                {
                    DocumentType = DocumentType.DriverLicence,
                    IdNumber = "123xyz"
                },
                Email = "some@gmail.com",
            };
            Assert.True(customer.IsValid());

        }
    }
}
