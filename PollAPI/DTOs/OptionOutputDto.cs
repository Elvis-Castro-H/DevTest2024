using PollAPI.Models;

namespace PollAPI.DTOs;

public class OptionOutputDto : IMapFrom<Option>
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Votes { get; set; }
}