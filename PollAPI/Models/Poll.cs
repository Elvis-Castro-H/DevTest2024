namespace PollAPI.Models;

public class Poll : BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public ICollection<Option> Options { get; set; }
    public ICollection<Vote> Votes { get; set; }
}