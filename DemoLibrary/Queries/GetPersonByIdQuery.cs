﻿using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModels>
    {
        public int Id { get; } = Id;
    }
}