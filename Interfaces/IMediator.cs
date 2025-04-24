using MediatR;

namespace MediatorPattern.Interfaces
{
    internal interface IMediator
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }
}
