using Persistence.Models;
using Application.Activites;
using Domain;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        private readonly IMediator _mediator;
       public FirstController(IMediator mediator) {
        _mediator = mediator;
        }

        public async Task<List<AdminFaq>> GetList()
        {
            return await _mediator.Send(new List.Query());
        }
        [HttpGet("{Id}")]
        public async Task<AdminFaq> GetDetails(int Id)
        {
            return await _mediator.Send(new Details.Command { ID=Id});
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdminFaq item)
        {
            await _mediator.Send(new Create.Command { adminFaq = item });
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id,AdminFaq item)
        {
            item.Id = id;
            await _mediator.Send(new Edit.Command { Activity = item });
            return Ok();
        }
    }
}
