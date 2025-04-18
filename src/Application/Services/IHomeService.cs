using Domain.Abstraction;
using Domain.Entities;

namespace Application.Services;

public interface IHomeService
{
    Result<Payment> Get_Payment_Json();
}
