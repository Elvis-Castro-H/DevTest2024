using PollAPI.Models;

namespace PollAPI.DTOs;

public class VoteInputDto : IMapFrom<Vote>
{
    public int OptionId { get; set; }
    public string VoterEmail { get; set; } = null!;
}