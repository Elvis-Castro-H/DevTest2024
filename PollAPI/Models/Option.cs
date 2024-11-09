namespace PollAPI.Models;

public class Option : BaseEntity<int>
{
    public string Name { get; set; } = null!;
    public int Votes { get; set; }
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    public ICollection<Vote> VotesList { get; set; }
}