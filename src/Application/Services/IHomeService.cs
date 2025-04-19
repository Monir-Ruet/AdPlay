using Domain.Abstraction;
using Domain.Entities;

namespace Application.Services;

public interface IHomeService
{
    Result<Payment> GetPaymentJson();
    Task<Result> CreateCheckOutUrl();
}
