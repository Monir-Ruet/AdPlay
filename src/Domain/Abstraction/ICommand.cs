using MediatR;

namespace Domain.Abstraction;

public interface ICommand : IRequest<Result> { }

public interface ICommand<TResponse> : IRequest<Result<TResponse>>{ };
