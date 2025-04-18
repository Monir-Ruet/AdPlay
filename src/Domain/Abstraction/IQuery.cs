using MediatR;

namespace Domain.Abstraction;

public interface IQuery<TResponse> : IRequest<Result<TResponse>> { }

public interface IQuery : IRequest<Result>;
