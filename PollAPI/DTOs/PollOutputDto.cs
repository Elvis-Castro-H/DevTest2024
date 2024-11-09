using PollAPI.Models;

namespace PollAPI.DTOs;

public class PollOutputDto : IMapFrom<Poll>
{
    public int Id { get; set; } 
    public string Name { get; set; } = null!;
    public ICollection<OptionOutputDto> Options { get; set; }
}