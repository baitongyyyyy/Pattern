using MediatR;

public record CreateEntityCommand(string Name) : IRequest<Guid>;