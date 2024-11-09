using PollAPI.DTOs;
using PollAPI.Models;

namespace PollAPI.Services;

public interface IPollService : IBaseService<PollOutputDto, PollInputDto, int>
{
    
}