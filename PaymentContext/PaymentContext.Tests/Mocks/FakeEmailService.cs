using PaymentCondext.Domain.Entities;
using PaymentCondext.Domain.Repositories;
using PaymentCondext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {

        }
    }
}