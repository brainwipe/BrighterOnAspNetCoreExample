using System;
using Paramore.Brighter;

namespace Domain.Commands
{
    public class CreateValueCommand : IRequest
    {
        public CreateValueCommand(string value)
        {
            Id = Guid.NewGuid();
            Value = value;
        }

        public string Value { get; }

        public Guid Id { get; set; }
    }
}
