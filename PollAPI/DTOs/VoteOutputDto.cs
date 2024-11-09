using PollAPI.Models;

namespace PollAPI.DTOs;

public class VoteOutputDto : IMapFrom<Vote>
{
    public int Id { get; set; }
    public int OptionId { get; set; }
    public int PollId { get; set; }
    public string VoterEmail { get; set; } = null!;
}