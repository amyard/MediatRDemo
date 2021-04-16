using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModels>
    {
        public string FirstName { get; } = FirstName;
        public string LastName { get; } = LastName;
    }
}