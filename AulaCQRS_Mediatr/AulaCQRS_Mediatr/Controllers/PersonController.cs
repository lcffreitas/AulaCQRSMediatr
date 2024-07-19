using AulaCQRS_Mediatr.Domain.Handlers;
using AulaCQRS_Mediatr.Domain.Request;
using AulaCQRS_Mediatr.Domain.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaCQRS_Mediatr.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class PersonController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public Task<AddPersonResponse> Add(AddPersonRequest command)
        {
            return _mediator.Send(command);
        }
    }
}
