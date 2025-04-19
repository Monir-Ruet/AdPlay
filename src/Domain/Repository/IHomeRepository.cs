using Domain.Abstraction;
using Domain.Entities;

namespace Domain.Repository;

public interface IHomeRepository
{
    Result<Payment> GetPaymentJson();
    Task<Result> CreateCheckOutUrl(Payment payment);
}
