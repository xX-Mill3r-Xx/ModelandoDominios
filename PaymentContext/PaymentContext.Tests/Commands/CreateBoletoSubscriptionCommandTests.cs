using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentCondext.Domain.Commands;
using PaymentCondext.Domain.Entities;
using PaymentCondext.Domain.Enums;
using PaymentCondext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}