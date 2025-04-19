using System.Text;
using System.Text.Json;
using Domain.Abstraction;
using Domain.Entities;
using Domain.Enums;
using Domain.Repository;

namespace Infrastructure.Repository;

public class HomeRepository : IHomeRepository
{
    public Result<Payment> GetPaymentJson()
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

    public async Task<Result> CreateCheckOutUrl(Payment payment)
    {
        try
        {
            var httpClient = new HttpClient();
            var checkOutEndPointUrl = "https://bkashtest.shabox.mobi/home/MultiTournamentInBuildCheckoutUrl";
            var json = JsonSerializer.Serialize(payment);
            using var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var request = new HttpRequestMessage(HttpMethod.Post, checkOutEndPointUrl);
            request.Content = data;
            request.Headers.Add("api-key", "796b8b9dbbf46b1d8fd73f68979ae31635da9afabc9dee147adf0440ee7118a8");
            var httpResponse = await httpClient.SendAsync(request);

            return httpResponse.IsSuccessStatusCode ? Result.Success(await httpResponse.Content.ReadAsStringAsync()) : Result.Failure("Http request failed");
        }
        catch (Exception ex)
        {
            return Result.Failure(ex.Message);
        }
    }
}
