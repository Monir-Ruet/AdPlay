using Domain.Abstraction;
using Domain.Entities;
using Domain.Enums;
using Domain.Repository;

namespace Infrastructure.Repository;

public class HomeRepository : IHomeRepository
{
    public Result<Payment> Get_Payment_Json()
    {
        List<string> redirectUrls =
        [
            "https://google.com",
            "https://facebook.com",
            "https://instagram.com"
        ];
        
        return Result.Success(new Payment
        {
            Amount = new Random().Next(1, 1000000),
            FirstPaymentIncludedInCycle = new Random().Next(2) == 0,
            ServiceId = Guid.NewGuid().ToString(),
            StartDate = DateTime.Now,
            EndDate = DateTime.Now + TimeSpan.FromDays(5),
            SubscriptionType = (SubscriptionType) (new Random().Next(0, Enum.GetValues(typeof(SubscriptionType)).Length)),
            Currency = (Currency) (new Random().Next(0, Enum.GetValues(typeof(Currency)).Length)),
            Frequency = (Frequency) (new Random().Next(0, Enum.GetValues(typeof(Frequency)).Length)),
            PaymentType = (PaymentType) (new Random().Next(0, Enum.GetValues(typeof(PaymentType)).Length)),
            PayerType = (PayerType) (new Random().Next(0, Enum.GetValues(typeof(PayerType)).Length)),
            SubscriptionRequestId = Guid.NewGuid().ToString(),
            SubscriptionReference = Guid.NewGuid().ToString(),
            CKey = Guid.NewGuid().ToString(),
            MaxCapRequired = new Random().Next(2) == 0,
            MerchantShortCode = Guid.NewGuid().ToString(),
            RedirectUrl = redirectUrls[new Random().Next(0, redirectUrls.Count)]
        });
    }
}
