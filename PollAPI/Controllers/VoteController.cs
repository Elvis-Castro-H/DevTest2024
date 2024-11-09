using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PollAPI.DTOs;
using PollAPI.Services;

namespace PollAPI.Controllers;

[ApiController]
[Route("api/v1/polls/{id}/votes")]
public class VoteController : ControllerBase
{
    private readonly IVoteService _service;
    private readonly IValidator<VoteInputDto> _validator;

    public VoteController(IVoteService service, IValidator<VoteInputDto> validator)
    {
        _service = service;
        _validator = validator;
    }

    [HttpPost]
    public async Task<ActionResult<VoteOutputDto>> Create([FromBody] VoteInputDto vote)
    {
        var response = await _service.Create(vote);
        return Ok(response);
    }

}