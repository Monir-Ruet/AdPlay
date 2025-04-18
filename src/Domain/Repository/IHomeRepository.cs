using Domain.Abstraction;
using Domain.Entities;

namespace Domain.Repository;

public interface IHomeRepository
{
    Result<Payment> Get_Payment_Json();
}
