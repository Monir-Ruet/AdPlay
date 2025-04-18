using Domain.Enums;

namespace Domain.Entities;

public class Payment
{
    public int Amount { get; set; }
    public bool FirstPaymentIncludedInCycle { get; set; }
    public string ServiceId { get; set; } = string.Empty;
    public Currency Currency { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Frequency Frequency { get; set; }
    public SubscriptionType SubscriptionType { get; set; }
    public bool MaxCapRequired { get; set; }
    public string MerchantShortCode { get; set; } = string.Empty;
    public PayerType PayerType { get; set; }
    public PaymentType PaymentType { get; set; }
    public string RedirectUrl { get; set; } = string.Empty;
    public string SubscriptionRequestId { get; set; } = string.Empty;
    public string SubscriptionReference { get; set; } = string.Empty;
    public string CKey { get; set; } = string.Empty;
}
