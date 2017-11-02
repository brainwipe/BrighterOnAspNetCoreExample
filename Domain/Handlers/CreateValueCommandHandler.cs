using System.Diagnostics;
using Domain.Commands;
using Paramore.Brighter;

namespace Domain.Handlers
{
    public class CreateValueCommandHandler  : RequestHandler<CreateValueCommand>
    {
        public override CreateValueCommand Handle(CreateValueCommand command)
        {
            Debug.WriteLine($"Creating value {command.Value}");
            return base.Handle(command);
        }
    }
}
