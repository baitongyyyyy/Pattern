using MediatR;

namespace MediatorPattern.Command.CreateEntity
{
    public class CreateEntityHandler : IRequestHandler<CreateEntityCommand, Guid>
    {
        public Task<Guid> Handle(CreateEntityCommand request, CancellationToken cancellationToken)
        {
            var entityId = Guid.NewGuid();
            Console.WriteLine($"Entity created with ID: {entityId}");

            return Task.FromResult(entityId);
        }
    }

    public record CreateEntityCommand : IRequest<Guid> // Ensure CreateEntityCommand implements IRequest<Guid>  
    {
        public string Name { get; init; }
    }
}