using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModels>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModels> Get(int id) => await _mediator.Send(new GetPersonByIdQuery(id));

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModels> Post([FromBody] PersonModels value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);

            return await _mediator.Send(model);
        }
    }
}
