using System.Collections.Generic;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    // override class to record. record is almost readonly 
    public record GetPersonListQuery() : IRequest<List<PersonModels>>;
    
    // as class
    // public class GetPersonListQueryClass  : IRequest<List<PersonModels>>
    // {
    // }
}