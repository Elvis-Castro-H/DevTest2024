using PollAPI.Models;

namespace PollAPI.DTOs;

public class OptionInputDto : IMapFrom<Option>
{
    public string Name { get; set; } = null!;
}