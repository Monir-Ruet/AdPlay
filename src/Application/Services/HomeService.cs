using Domain.Abstraction;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services;

public class HomeService(IHomeRepository homeRepository) : IHomeService
{
    public Result<Payment> Get_Payment_Json()
    {
        return homeRepository.Get_Payment_Json();
    }
}
