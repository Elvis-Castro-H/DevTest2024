using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PollAPI.DTOs;
using PollAPI.Services;

namespace PollAPI.Controllers;

[ApiController]
[Route("api/v1/polls")]
public class PollController : ControllerBase
{
    private readonly IPollService _service;
    private readonly IValidator<PollInputDto> _validator;

    public PollController(IPollService service, IValidator<PollInputDto> validator)
    {
        _service = service;
        _validator = validator;
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<PollOutputDto>>> GetAll()
    {
        var response = await _service.GetAll();
        if (response == null)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<PollOutputDto>> Create([FromBody] PollInputDto poll)
    {
        var pollCreated = await _service.Create(poll);
        return pollCreated == null ? BadRequest() : Ok(pollCreated);
    }
    
}