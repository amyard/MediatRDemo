using System.Linq;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModels>
    {
        private readonly IMediator _mediator;

        // bring another mediator
        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public async Task<PersonModels> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetPersonListQuery(), cancellationToken);

            var output = result.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}