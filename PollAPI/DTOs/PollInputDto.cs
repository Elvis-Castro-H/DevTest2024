using PollAPI.Models;

namespace PollAPI.DTOs;

public class PollInputDto : IMapFrom<Poll>
{
    public string Name { get; set; } = null!;
    public ICollection<OptionInputDto> Options { get; set; }
}